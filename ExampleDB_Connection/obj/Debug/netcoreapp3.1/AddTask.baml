   M S B A M L   `   `   `  ����O  KExampleDB_Connection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ExampleDB_ConnectionExampleDB_Connection  5   	   "    ExampleDB_Connection.AddTask   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ExampleDB_Connection     5   	     � Title$  Add new Task��5   	   $	��300��6   $	��400��6+    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�6   ���#2a382f���#1fe554.��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� -   5         ��Name$ HeadText��5      $��1��5      $��1��6   Add new Task5      �� 5    
    �� Orientation$ 
Horizontal=�6   $��1��5!      $��2��6   .+�5"      �� $ Vertical=�6   $	��100��60   $��5q�6<   .+�5#      �� $��5q�6   	Content60   �� 5$      $��5q�6   State6.   5%      �� 5&      $ Vertical=�6   $	��160��60   $��5q�6<   .+�5'      �� -   5         ��Name$ Content��5'      $��5q�5(      $	��150��6    6.   	� 5)      -   5         	�Name$ 
Incomplete��5)      	 	� 	GroupName$	 State��62   ���#1fe554$��5q�5*      .��6    
Incomplete6,   	� 5+      -   5        $ 
InProgress��5+      $	 State��62   ���#1fe554$��5q�5,      .��6    In Progress6-   	� 5-      -   5        $ Complete��5-      $	 State��60   ���#1fe554$��5q�5.      .��6    
Complete6*   5/      50      �� 51   
   -   5        
 ��Name$
 Confirm��51      $��1��52      $��3��6   $	��150��53      $��20��6   .��6%   Confirm new Task55      57      58      