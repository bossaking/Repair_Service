   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   I ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service 5   	   =#clr-namespace:Repair_Service.ModelsRepair_Service.Models 5   	   #   Repair_Service.NewOrderWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   .localclr-namespace:Repair_Service     5   	   6models#clr-namespace:Repair_Service.Models     5   	     � Title$  Новый заказ��5
   	   $	��450��6   $	��500��6*    � WindowStartupLocation$ CenterOwner=�66    � 	Resources 5         dataFromEnums S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� TypeName��%r   &	        S� 5   
   $ 	GetValues��63   "  6J    5      M� 5      $ models:Type��6   5      5      .��5      �  � ShowGridLines .   � ColumnDefinitions 5   
   �� 5      $
��auto �6   6.   �� 5      6!   	 � RowDefinitions	 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6   .+�5    
   �� $��0��6   $��ФИО клиента:��6    $��Center=�67   6T   �� 5!   
   -   5        
 ��Name$
 ownerNameText��5!      $��10q�6)   $��0��65   $��1��6B   6T   �� 5#   
   $��0��6   $��Телефон:��6    $��Center=�63   $��1��6N   6]   �� 5$   
   -   5        $
 phoneNumberText��5$      $��1��6+   $��1��6;   $��10q�6H   6W   �� 5&   
   $��0��6   $"��Начальная цена:��6    $��Center=�6:   $��2��6U   6d   �� 5'   
   -   5        $
 startPriceText��5'      $��1��6*   $��2��6:   $��10q�6G   $��0��6S   6^   �� 5)   
   $��0��6   $��Тип:��6    $��Center=�6/   $��3��6J   6Y   �� 5*   
   -   5         ��Name$ typesComboBox��5*      $��1��6*   $��3��6:   $��10q�6G   ��6S   ��  �� Source# [  6�   �� 5,   
   $��0��6   $��Проблемы:��6    $	��Top=�64   $��4��6L   $
��0,10q�6Y   6i   �� 5-   
   -   5        $
 mainProblemText��5-      $	��150��6+   $��10q�6;   $��4��6G   $��1��6T    �� TextWrapping$
 Wrap=�6d   " �� VerticalScrollBarVisibility$ Visible=�6x   6�   �� 5/   
   -   5         ��Name$ addNewOrderButton��5/      $��10,10q�6,   $��40��6;   $
��10,0q�6J   $��5��6y   $��1��6�   $��Right=�6�   $��Bottom=�6�   .��6�   Добавить6�   51      52      