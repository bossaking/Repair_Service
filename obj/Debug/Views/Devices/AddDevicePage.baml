   M S B A M L   `   `   `  ����I  ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service  5      =#clr-namespace:Repair_Service.ModelsRepair_Service.Models  5      "    Repair_Service.AddDevicePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Repair_Service     5      6local1#clr-namespace:Repair_Service.Models     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          N� 
Background
  ����� N� FontSize$ 16(�5      .��5      � -   5        $��MainGrid��5   	   $��200,0,200,0q�5   	   $��Center=�5   	    � ShowGridLines .   � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5!   
   �� $��0��5"      $��0��5#      $��0,0,0,10q�5$      $��Center=�5%      .��6/   Model title:5'      �� 5(   
   $��0��5)      $��1��5*      $��5,5,5,15q�5+      $
��Left=�5,      $��Center=�5-      .��6/   ��5.      �� 5/       �� Path$ Model_Title�6    �� UpdateSourceTrigger$ PropertyChanged=�6-    �� ValidationRules 50      -   'Repair_Service.Models.NonEmptyFieldRule  51      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 63   53      .��54      55      �� 59   
   $��1��5:      $��0��5;      $��0,0,0,10q�5<      $��Center=�5=      .��6/   Type:5?      �� 5@   
   -   5        $��TypesComboBox��5A      $��1��5B      $��1��5C      $��5,5,5,15q�5D      $��5q�5E      $��Center=�5F      	 �� DisplayMemberPath$	 
Type_Title��5G      
 �� IsTextSearchEnabled
 .  �� SelectedIndex$ 0��5I       w� TextPath$ Content��5J      �� 5N   
   $��2��5O      $��0��5P      $��Center=�5Q      .��6/   Brand:5S      �� 5T   
   -   5         ��Name$ BrandsComboBox��5U      $��2��5V      $��1��5W      $��5q�5X      $��5q�5Y      $��Center=�5Z      $	 Title��5[      
 . $ 0��5]      $ Content��5^      � 5b   
   $��3��5c      $��0��5d      $��2��5e      $��5,20,5,5q�5f      $��Center=�5g      .+�5h      �� -   5        $��75��5i      $
��10,5q�5j       �� 	IsDefault . .��5l   "   OK5n      �� 5o      -   5        $��75��5p      $��5,0,0,0q�5q      $
��10,5q�5r       �� IsCancel . .��5t   !   Cancel5v      5w      5y      5{      