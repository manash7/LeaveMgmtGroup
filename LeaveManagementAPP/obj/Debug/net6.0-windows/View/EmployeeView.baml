   M S B A M L   `   `   `  ????M  ILeaveManagementAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:LeaveManagementAPP.ViewLeaveManagementAPP.View  5      *    $LeaveManagementAPP.View.EmployeeView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:LeaveManagementAPP.View     5      $	??450??5      $	??600??6   .??5	      ? .+?5
   
   ?   ? RowDefinitions  5      ?? 5      $
??Auto ?6    ?? 5      $??* ?6    .+?5      ? $??0??6    ? ColumnDefinitions 5      ?? 5      $??2* ?6'   ?? 5      $??* ?6'   .+?5      ? $??0??6   .+?5      ?   5      ?? 5      $
??Auto ?6,   ?? 5      $??* ?6,    5      ?? 5      $??* ?6/   ?? 5      $??* ?6/   ?? 5       $??* ?6/   .+?5$      ?? $??0??6%   $??3??62   ???#3AE8AD.+?5%      ?? $??Manage Employee??6$   $
??Bold"?6>   $??20(?6P   5&      ?? 5(      -   5         ??Name$ 	textEmpID??5(   $   $y?Hidden=?67   ?? 5)      $??0??6%   $??1??65   .+?5*      ?? $??Employee Name??6$   $??10 0 0 0q?6<   ?? 5+      -   5        $ textEmpName??5+   &   $??10 0 0 0q?6<   $??Center=?6N   ?? 5-      $??Employee Gender??6$   $??10 0 0 0q?6>   ?? 5.      -   5         ??Name$ comboEmpGender??5.   '   $??
10 0 10 10q?6?   $??Center=?6T   ?? 50      $??IsAdmin??6$   $??10 0 0 0q?66   ?? 51      -   5        $ comboIsAdmin??51   '   $??
10 0 10 10q?6=   $??Center=?6R   53      ?? 55      $??1??6%   $??1??65   .+?56      ?? $??Employee Email??6$   $??10 0 0 0q?6=   ?? 57      -   5        $ textEmpEmail??57   &   $??	10 0 10 4q?6<   $??Center=?6P   ?? 59      $??Employee Password??6$   $??10 0 0 0q?6@   ?? 5:      -   5        $ textEmpPassword??5:   &   $??
10 0 10 10q?6?   $??Center=?6S   5<      ?? 5>      $??2??6%   $??1??65   .+?5?      ?? $??Employee Address??6$   $??10 0 0 0q?6?   ?? 5@      -   5        $ textEmpAddress??5@   &    ?? MaxLines$ 7??6>   $??
10 0 10 10q?6K    ?? TextWrapping$
 Wrap=?5A       ?? AcceptsReturn$
 True??6*   " ?? VerticalScrollBarVisibility$ Visible=?5B      $??70??6<   5D      5F      5G      ?? 5J      $??1??6   $??Center=?6.   $??
0 -40 0 10q?6I   ???#3F79DA$	??150??6r   .+?5K      ?? -   5        $	??Add??5K      $??	0 50 10 0q?6+   $	??120??6>   6J   ?? 5L      -	   5        $??Update??5L      $??	0 10 10 0q?6.   $	??120??6A   6M   ?? 5M      -
   5        $??Delete??5M      $??	0 10 10 0q?6.   $	??120??6A   6M   5N      5O      ?? 5P      $??1??6   .+?5Q      &   System.Windows.Controls.DataGrid  -   5          Name$ EmployeeTable??5Q   (   $??1??6   $??
10 10 10 0q?6?   $	??200??5R      $	??580??6(   	   AutoGenerateColumns$	 False??5S      $
??Auto=?67   $
??Auto=?5T      
   
IsReadOnly$

 True??6K      Columns 5U      0  *System.Windows.Controls.DataGridTextColumn  5V      ,  &System.Windows.Controls.DataGridColumn   Header$ EmpID??6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   ?? *EmpID+  5W      $
 Name??6-    6;   ?? *	EmpName+  5X      $ Email??6-    6<   ?? *
EmpAddress+  5Y      $ Address??6-    6>   ?? *
EmpEmail+  5Z      $ Gender??6-    6=   ?? *	EmpGender+  5[      $ IsAdmin??6-    6>   ?? *Is_SuperUser+5]      5^      5_      5a      5b      