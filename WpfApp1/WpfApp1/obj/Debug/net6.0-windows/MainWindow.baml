   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     ? Title$  
MainWindow??5   	   $	??640??6   $	??480??6)   $	??640??65   $	??480??6E   .??5
      ? -   5         ?Name$ TheGrid??5
       ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??3* ?6   ?? 5      $??3* ?6   ?? 5      $??3* ?6   ?? 5      $??6* ?6   ?? 5      $??1* ?6   .+?5   
   ]? .+?5      o? $	??Top=?6   $??0??6(   .@?5      m? $??_File??6   .@?5      m? -   5        $??_Save??5      6.   ?? 5      m? 5      -   5        $??_Exit??5      6.   5      5      5      ?? 5   
   $??32,0,236,80q?6   $??Segoe UI Semibold)?6%   $??Registration Number??6D   $??1??5       ?? 5!   
   -   5         ??Name$ cmbRegistration??5!      $??
31,35,33,0q?6,   $	??Top=?6@   $??1??6X    ?? 
IsReadOnly$ false??5"       ?? 
IsEditable$
 true??6&   ??5#   @   ?? *RegistrationNumber+5$      ?? 5&   
   $??32,0,236,80q?6   $??Segoe UI Semibold)?6%   $
??Type??6D   $??2??6S   ?? 5'   
   -   5        $ cmbType??5'      $??
31,35,33,0q?6$   $	??Top=?68   $??2??6P   ??5(   1   ?? *Type+.@?5)      ?? .??6   Cat6    ?? 5*      .??6   Dog6    5+      ?? 5-   
   $??32,0,236,80q?6   $??Segoe UI Semibold)?6%   $
??Race??6D   $??3??6S   ?? 5.   
   -   5         ??Name$ tbRace??5.      $??Stretch=?6"   $??
32,35,32,0q?6@    ?? TextWrapping$
 Wrap=?5/      $	??Top=?6&   $
??auto??6>   $??3??50      6   ?? 52   
   $??32,0,236,190q?6   $??Segoe UI Semibold)?6&   $??Description??6E   $??4??53      ?? 54   
   -   5        $ tbDescription??54      $??Stretch=?6)   $??
32,35,32,0q?6G   $
 Wrap=?55      $	??Top=?6&   $	??120??6>   $??4??56   2   ?? 58   
   -   5        $??Create??58      $??Right=?6"   $??
0,174,40,0q?6>   $	??Top=?59      $??70??6)   $??4??64   6A   ?? 5;   
   $??0,0,2,0q?6   $??5??6%   ?? 5<   
   -	   5        $ tbStatus??5<      $??Stretch=?6$   $??	15,0,15,0q?6B   $??Center=?5=      $
 Wrap=?6-   $??Input model...??6A   $
??auto??5>      $??5??6     ?? 
IsReadOnly$
 True??6-   	 ? Cursor$	 Arrow??6?   5?      5@      