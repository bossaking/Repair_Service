   M S B A M L   `   `   `  ����I  ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service  5      =#clr-namespace:Repair_Service.ModelsRepair_Service.Models  5      )    #Repair_Service.AddEditEmployeesPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Repair_Service     5      6local1#clr-namespace:Repair_Service.Models     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� 
Background
  ����� N� FontSize$ 16(�5      .��5      � -   5        $��MainGrid��5   	   $��200,0,200,0q�5   	   $��Center=�5   	    � ShowGridLines .   � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5#   
   �� $��0��5$      $��0��5%      $��0,0,0,10q�5&      $��Center=�5'      .��6/   Name:5)      �� 5*   
   $��0��5+      $��1��5,      $��5,5,5,15q�5-      $
��Left=�5.      $��Center=�5/      .��6/   ��50      �� 51       �� Path$
 Name�6    �� UpdateSourceTrigger$ PropertyChanged=�6&    �� ValidationRules 52      -   'Repair_Service.Models.NonEmptyFieldRule  53      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 63   55      .��56      57      �� 5;   
   $��1��5<      $��0��5=      $��0,0,0,10q�5>      $��Center=�5?      .��6/   
Surname:5A      �� 5B   
   $��1��5C      $��1��5D      $��5,5,5,15q�5E      $
��Left=�5F      $��Center=�5G      .��6/   ��5H      �� 5I      $ Surname�6   $ PropertyChanged=�6)    5J        5K       . 63   5M      .��5N      5O      �� 5S   
   $��2��5T      $��0��5U      $��0,0,0,10q�5V      $��Center=�5W      .��6/   Login:5Y      �� 5Z   
   $��2��5[      $��1��5\      $��5,5,5,15q�5]      $
��Left=�5^      $��Center=�5_      .��6/   ��5`      �� 5a      $ Login�6   $ PropertyChanged=�6'    5b        5c       . 63   5e      .��5f      5g      �� 5k   
   $��3��5l      $��0��5m      $��0,0,0,10q�5n      $��Center=�5o      .��6/   	Password:5q      �� 5r   
   $��3��5s      $��1��5t      $��5,5,5,15q�5u      $
��Left=�5v      $��Center=�5w      .��6/   ��5x      �� 5y      $ Passwd�6   $ PropertyChanged=�6(    5z        5{       . 63   5}      .��5~      5      �� 5�   
   $��4��5�      $��0��5�      $��0,0,0,10q�5�      $��Center=�5�      .��6/   Salon:5�      �� 5�   
   -   5        $��SalonComboBox��5�      $��4��5�      $��1��5�      $��5,5,5,15q�5�      $��5q�5�      $��Center=�5�      	 �� DisplayMemberPath$	 Title��5�      
 �� IsTextSearchEnabled
 .  �� SelectedIndex$ 0��5�       w� TextPath$ Content��5�      �� 5�   
   $��5��5�      $��0��5�      $��Center=�5�      .��6/   Role:5�      �� 5�   
   -   5         ��Name$ RolesComboBox��5�      $��5��5�      $��1��5�      $��5q�5�      $��5q�5�      $��Center=�5�      $	 Title��5�      
 . $ 0��5�      $ Content��5�      � 5�   
   $��6��5�      $��0��5�      $��2��5�      $��5,20,5,5q�5�      $��Center=�5�      .+�5�      �� -   5        $��75��5�      $
��10,5q�5�       �� 	IsDefault . .��5�   "   OK5�      �� 5�      -   5        $��75��5�      $��5,0,0,0q�5�      $
��10,5q�5�       �� IsCancel . .��5�   !   Cancel5�      5�      5�      5�      