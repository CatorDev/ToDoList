   M S B A M L   `   `   `  ����O  KExampleDB_Connection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ExampleDB_ConnectionExampleDB_Connection  5   	   %    ExampleDB_Connection.RemoveTask   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ExampleDB_Connection     5   	     � Title$  
RemoveTask��5   	   $	��200��6   $	��200��6)    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�6   ���#2a382f���#1fe554.��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6$   $��5q�61   $	��140��6<   Enter the ID to remove5      �� 5   
   -   5         ��Name$ Input��5      $��1��5       $��2��6"   $��5q�6/   $	��140��6:   .��6F   5!      �� 5#   
   -   5         ��Name$ Confirm��5#      $��1��5$      $��3��6!   $��5q�6.   $��20��69   .��6E   Delete5&      5'      5(      