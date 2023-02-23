using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Classes;
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string? registrationNumber;
        private string? type;
        private string? race;
        private string? description;
        private Dictionary<string, Pet> pets;
        //ObservableCollection<Pet> pets;
        private ObservableCollection<string> regnr;

        public MainWindow()
        {
            pets = new Dictionary<string, Pet>();
            //pets = new ObservableCollection<Pet>();
            regnr = new ObservableCollection<string>();
            InitializeComponent();
            cmbRegistration.ItemsSource = regnr;
            AddHandler(FrameworkElement.MouseDownEvent, new MouseButtonEventHandler(MouseButtonDownHandler), true);
        }

        private void CreatePet(object sender, RoutedEventArgs e)
        {
            
            
            var fields = typeof(Pet).GetProperties();

            if (type == null)
            {
                tbStatus.Text = "Please select type!";
                return;
            }

            Pet pet = type == "Dog" ? new Dog() : new Cat(); // Add errorhandling


            pet.Description = description;
            pet.Race = race;
            pet.RegistrationNumber = registrationNumber;
            
            foreach (var field in fields)
            {
                if (field.GetValue(pet, null) == null)
                {
                    tbStatus.Text = "Please input " + field.Name + "!";
                    return;
                }
            }
            //pets.Add(pet);
            if (!pets.ContainsKey(registrationNumber))
                regnr.Add(registrationNumber);
            pets[pet.RegistrationNumber] = pet;
            tbStatus.Text = "Pet successfully created!";
        }

        // Updates all values based on the current registration number
        private void SetValues()
        {
            tbDescription.Text = pets[registrationNumber].Description;
            tbRace.Text = pets[registrationNumber].Race;
            cmbType.SelectedIndex = pets[registrationNumber].GetType().Name == "Cat" ? 0 : 1;
        }

        // Typing a new registration number in combobox
        private void UpdateRegistration(object sender, TextChangedEventArgs e)
        {
            registrationNumber = ((ComboBox)sender).Text;
        }
        // Selecting registration number from dropdown
        private void SelectRegistration(object sender, SelectionChangedEventArgs e)
        {
            try 
            { 
                registrationNumber = ((object)e.AddedItems[0]).ToString(); 

                if (pets.ContainsKey(registrationNumber))
                {
                    SetValues();
                }
            } 
            catch (IndexOutOfRangeException ex) 
            {
                Debug.WriteLine(ex.Message);    
            }
        }

        // Updates the type of pet
        private void UpdateType(object sender, SelectionChangedEventArgs e)
        {
            if(e.AddedItems.Count > 0)
                type = ((ComboBoxItem)e.AddedItems[0]).Content.ToString();
        }

        // Updates the race of a pet
        private void UpdateRace(object sender, TextChangedEventArgs e)
        {
            race = ((TextBox)sender).Text;
        }

        // Updates the description of a pet
        private void UpdateDescription(object sender, TextChangedEventArgs e)
        {
            description = ((TextBox)sender).Text;
        }

        // Added this for additional feedback 
        private void MouseButtonDownHandler(object sender, MouseButtonEventArgs e)
        {
            tbStatus.Text = "Status OK!";
        }

        private void SaveFile(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.AddExtension = true;

            String csv = "Registration number, Type, Race, Description \n"; 
            
            csv += String.Join(
                Environment.NewLine,
                pets.Select(d => $"{d.Key}, {d.Value.GetType().Name}, {d.Value.Race}, {d.Value.Description}")
            );

            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, csv);
            }
        }

        private void ExitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ThrowError()
        {

        }
    }
}
