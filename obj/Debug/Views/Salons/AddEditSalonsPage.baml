   M S B A M L   `   `   `  ����I  ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service  5      =#clr-namespace:Repair_Service.ModelsRepair_Service.Models  5      &     Repair_Service.AddEditSalonsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Repair_Service     5      6local1#clr-namespace:Repair_Service.Models     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� 
Background
  ����� N� FontSize$ 16(�5      .��5      � -   5        $��MainGrid��5   	   $��200,0,200,0q�5   	   $��Center=�5   	    � ShowGridLines .   � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5!   
   �� $��0��5"      $��0��5#      $��0,0,0,10q�5$      $��Center=�5%      .��6/   Salon title:5'      �� 5(   
   $��0��5)      $��1��5*      $��5,5,5,15q�5+      $
��Left=�5,      $��Center=�5-      .��6/   ��5.      �� 5/       �� Path$ Title�6    �� UpdateSourceTrigger$ PropertyChanged=�6'    �� ValidationRules 50      -   'Repair_Service.Models.NonEmptyFieldRule  51      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 63   53      .��54      55      �� 59   
   $��1��5:      $��0��5;      $��Center=�5<      .��6/   	Location:5>      �� 5?   
   $��1��5@      $��1��5A      $��5q�5B      $
��Left=�5C      $��Center=�5D      .��6/   ��5E      �� 5F      $ Location�6   $ PropertyChanged=�6*    5G        5H       . 63   5J      .��5K      5L      � 5P   
   $��2��5Q      $��0��5R      $��2��5S      $��5,20,5,5q�5T      $��Center=�5U      .+�5V      �� -   5        $��75��5W      $
��10,5q�5X      	 �� 	IsDefault	 . .��5Z   "   OK5\      �� 5]      -   5        $��75��5^      $��5,0,0,0q�5_      $
��10,5q�5`      
 �� IsCancel
 . .��5b   !   Cancel5d      5e      5g      5i      