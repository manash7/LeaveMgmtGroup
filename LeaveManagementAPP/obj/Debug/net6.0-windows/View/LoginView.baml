   M S B A M L   `   `   `  ????M  ILeaveManagementAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:LeaveManagementAPP.ViewLeaveManagementAPP.View  5      '    !LeaveManagementAPP.View.LoginView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:LeaveManagementAPP.View     5      .??5	      ?   ? ColumnDefinitions  5
   
   ?? 5      $	??100 ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? $??0??6   ???#3F79DA5      ?? 5   
   $??1??6   .+?5      ?  ? RowDefinitions 5      ?? 5      $??50 ?6$   ?? 5      $
??Auto ?6$   .+?5      ?? $??0??6    ?? Orientation$ 
Horizontal=?6*   ???#3AE8AD$??50??6X   $??	0,0,100,0q?6d   .+?5      ?? 5      ?? 5      $??1??6   $??0,0,150,-131q?6*   .+?5      ?? -   5        $??LoginHeading??5   S   $??23??6    $
??Left=?6,   $??10q?6G   $??Login:??6g   $	??Top=?6u   $??17(?6?   $??ExtraCondensed&?6?   ?? 5      -   5        $??Email??5   W   $??23??6    $
??Left=?6,   $??200,10q?6G   $??Email??6d   $	??Top=?6q   $??67??6?   ?? 5       -   5        $??	textEmail??5    W   $??23??6   $
??Left=?6+   $??200,10q?6G   $	??Top=?6h   $	??247??6?   $??Center=?6?   ?? 5"      -   5        $??Password??5"   W   $??23??6    $
??Left=?6,   $??200,10q?6G   $??Password??6g   $	??Top=?6w   $??77??6?   G? 5#      -   5        $??textPassword??5#   Y   $??23??6"   $
??Left=?6.   $??200,10q?6I   $	??Top=?6m   $	??247??6?   $??Center=?6?   ?? 5%      -   5        $??button1??5%   e   $??Login??6   $??23??6.   $
??Left=?6:   $??200,10q?6U   $	??Top=?6t   $	??104??6?   58      59      5:      5<      5>      