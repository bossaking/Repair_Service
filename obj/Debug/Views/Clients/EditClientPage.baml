   M S B A M L   `   `   `  ����I  ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service  5      =#clr-namespace:Repair_Service.ModelsRepair_Service.Models  5      #    Repair_Service.EditClientPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Repair_Service     5      6local1#clr-namespace:Repair_Service.Models     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� 
Background
  ����� N� FontSize$ 16(�5      .��5      � -   5        $��MainGrid��5   	   $��200,0,200,0q�5   	   $��Center=�5   	    � ShowGridLines .   � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5    
   �� $��0��5!      $��0��5"      $��0,0,0,10q�5#      $��Center=�5$      .��6/   Name:5&      �� 5'   
   -   5        $��ClientNameTextBox��5(      $��0��5)      $��1��5*      $��5,5,5,15q�5+      $
��Left=�5,      $��Center=�5-      .��6/   ��5.      �� 5/       �� Path$
 Name�6    �� UpdateSourceTrigger$ PropertyChanged=�6&    �� ValidationRules 50      -   'Repair_Service.Models.NonEmptyFieldRule  51      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 63   53      .��54      55      �� 59   
   $��1��5:      $��0��5;      $��0,0,0,10q�5<      $��Center=�5=      .��6/   
Surname:5?      �� 5@   
   -   5        $��ClientSurnameTextBox��5A      $��1��5B      $��1��5C      $��5,5,5,15q�5D      $
��Left=�5E      $��Center=�5F      .��6/   ��5G      �� 5H      $ Surname�6   $ PropertyChanged=�6)    5I        5J       . 63   5L      .��5M      5N      �� 5R   
   $��2��5S      $��0��5T      $��Center=�5U      .��6/   Phone number:5W      �� 5X   
   -   5        $��ClientPhoneNumberTextBox��5Y      $��2��5Z      $��1��5[      $��5q�5\      $
��Left=�5]      $��Center=�5^      .��6/   ��5_      �� 5`      $ Phone_Number�6   $ PropertyChanged=�6.    5a        5b       . 63   5d      .��5e      5f      � 5j   
   $��3��5k      $��0��5l      $��2��5m      $��5,20,5,5q�5n      $��Center=�5o      .+�5p      �� -   5        $��75��5q      $
��10,5q�5r      	 �� 	IsDefault	 . .��5t   "   OK5v      �� 5w      -   5        $��75��5x      $��5,0,0,0q�5y      $
��10,5q�5z      
 �� IsCancel
 . .��5|   !   Cancel5~      5      5�      5�      