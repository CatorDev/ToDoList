   M S B A M L   `   `   `  ����O  KExampleDB_Connection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ExampleDB_ConnectionExampleDB_Connection  5   	   %    ExampleDB_Connection.UpdateTask   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ExampleDB_Connection     5   	     � Title$  
UpdateTask��5   	   $	��300��6   $	��500��6)    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�6   ���#2a382f���#1fe554.��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� -   5         ��Name$ HeadText��5      $��1��5      $��1��6   Update Task5       �� 5"   
    �� Orientation$ 
Horizontal=�6   $��1��5#      $��2��6   .+�5$      �� $ Vertical=�6   $	��150��60   $��5q�6<   .+�5%      �� $��5q�6   Current Content68   �� 5&      -   5         ��Name$ UpdateContent��5&       d� 	IsChecked$
 TrueY�5'      $��5q�6*   .��5(      �� ���#1fe554Updated Content6G   5)      �� 5*      $��5q�6   Current Status67   �� 5+      -   5        $ UpdateStatus��5+      $
 TrueY�5,      $��5q�6*   .��5-      �� ���#1fe554
New Status6A   5.      5/      �� 50      $ Vertical=�6   $	��200��60   $��5q�6<   .+�51      �� -   5        	 ��Name$	 CurrentContent��51      
 �� 
IsReadOnly$

 True��62   $��5q�52      $	��200��6    6.   �� 53      -   5        $	 
NewContent��53      $��5q�54      $	��200��6    6.   �� 55      -   5        $	 CurrentStatus��55      $

 True��61   $��5q�56      $	��200��6    6.   	� 57      -   5         	�Name$ 
Incomplete��57       	� 	GroupName$ State��62   ���#1fe554$��5q�58      .��6    
Incomplete6,   	� 59      -   5        $ 
InProgress��59      $ State��62   ���#1fe554$��5q�5:      .��6    In Progress6-   	� 5;      -	   5        $ Complete��5;      $ State��60   ���#1fe554$��5q�5<      .��6    
Complete6*   5=      5>      �� 5?   
   -
   5         ��Name$ ConfirmUpdate��5?      $��1��5@      $��3��6   $	��150��5A      $��20��6   .��6%   Confirm Update5C      5D      5E      