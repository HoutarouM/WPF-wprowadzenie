   M S B A M L   `   `   `  ????G  CWprowadzenie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WprowadzenieWprowadzenie  5   	        Wprowadzenie.WindowKwadrat   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Wprowadzenie     5   	     ? Title$  WindowKwadrat??5   	   $	??350??6   $	??400??6,   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5      .+?5   
   ?? Bok kwadratu6"   ?? 5   
   -   5         ??Name$ 
boktextbox??5   "   $??1??6   6"   ?? 5   
   -   5         ??Name$ 	komunikat??5      
???  ??$??3??68   ?? 5   
   $??1??6   Pole kwadratu60   ?? 5   
   -   5        $ poletextbox??5   A   ${?False??6   $??1??6$   $??1??61   6A   ?? 5   
   $??2??6   Obwod kwadratu61   ?? 5   
   -   5        $ obwodtextbox??5   A   ${?False??6   $??2??6$   $??1??61   6A   ?? 5!   
   -   5        $??3??5!      $??3??6   .??6G   Oblicz6O   5"      5#      