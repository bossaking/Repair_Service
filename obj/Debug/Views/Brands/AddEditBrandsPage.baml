   M S B A M L   `   `   `  ����I  ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service  5      =#clr-namespace:Repair_Service.ModelsRepair_Service.Models  5      &     Repair_Service.AddEditBrandsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Repair_Service     5      6local1#clr-namespace:Repair_Service.Models     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� 
Background
  ����� N� FontSize$ 16(�5      .��5      � -   5        $��MainGrid��5   	   $��200,0,200,0q�5   	   $��Center=�5   	    � ShowGridLines .   � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5    
   �� $��0��5!      $��0��5"      $��Center=�5#      .��6/   Brand title:5%      �� 5&   
   $��0��5'      $��1��5(      $��5q�5)      $
��Left=�5*      $��Center=�5+      .��6/   ��5,      �� 5-       �� Path$ Title�6    �� UpdateSourceTrigger$ PropertyChanged=�6'    �� ValidationRules 5.      -   'Repair_Service.Models.NonEmptyFieldRule  5/      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 63   51      .��52      53      � 57   
   $��1��58      $��0��59      $��2��5:      $��5,20,5,5q�5;      $��Center=�5<      .+�5=      �� -   5        $��75��5>      $
��10,5q�5?      	 �� 	IsDefault	 . .��5A   "   OK5C      �� 5D      -   5        $��75��5E      $��5,0,0,0q�5F      $
��10,5q�5G      
 �� IsCancel
 . .��5I   !   Cancel5K      5L      5N      5P      