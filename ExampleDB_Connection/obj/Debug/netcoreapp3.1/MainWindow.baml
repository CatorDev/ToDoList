   M S B A M L   `   `   `  ����O  KExampleDB_Connection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ExampleDB_ConnectionExampleDB_Connection  5   	   %    ExampleDB_Connection.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ExampleDB_Connection     5   	     � Title$  
MainWindow��5   	   $
��auto��6   $
��auto��6*   ���#2a382f���#1fe554 � WindowStartupLocation$ CenterScreen=�5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6$   $��20(�61   $��10q�6?   
To-Do List5      �� 5   
   $��1��6   $��2��6%    �� Orientation$ 
Horizontal=�62   $��10q�6K   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ ToDoList��5      $	��400��6)   $	��200��68   6J   �� 5      $ Vertical=�6   $��5q�60   .+�5      �� Manage Tasks5!      �� 5"      -   5         ��Name$ AddTask��5"      $	��200��5#      $��25��6!   $��5q�6-   .��68   
Add Task5%      �� 5&      -   5        $ 
UpdateTask��5&      $	��200��5'      $��25��6!   $��5q�6-   .��68   Update Selected Task5)      �� 5*      -   5        $ 
DeleteTask��5*      $	��200��5+      $��25��6!   $��5q�6-   .��68   Delete Selected Task5-      �� 5.      -   5        $ DeleteTaskByID��5.      $	��200��5/      $��25��6!   $��5q�6-   .��68   Delete Task by ID51      52      53      54      55      