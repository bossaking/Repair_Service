   M S B A M L   `   `   `  ����I  ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service  5      !    Repair_Service.DeleteWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Repair_Service     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  DeleteWindow��5      $	��300��5	      $	��200��5
       � AllowsTransparency . 
������  � WindowStartupLocation$ CenterOwner=�5       � WindowStyle$
 None=�5      .��5      �� 
�������
�������$��1q�5   	    �� CornerRadius$ 40��5   	   ._�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      �� 5      .+�5      �� $��0��5      $��0,15,0,0q�5      $��Center=�5      $��30(�5       $��	ExtraBold"�5!      
���   �DELETE ITEM5$      �� 5%      $��1��5&      $��5q�5'      $��Center=�5(      $��20(�5)      $��	ExtraBold"�5*      
���   � �� TextAlignment$ Center=�5,      $
��Wrap=�5-      53Are you sure you want to remove the selected order?5/      �� 50      $��2��51      $��Center=�52       �� Orientation$ 
Horizontal=�53      .+�54      �� -   5        $��75��55      $��5q�56       �� 	IsDefault . .��58   &   YES5:      �� 5;      -   5        $��75��5<      $��5q�5=      	 �� IsCancel	 . .��5?   %   NO5A      5B      5C      5D      5F      