   M S B A M L   `   `   `  ????H  DTest_Task_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Test_Task_WPF.ViewsTest_Task_WPF.Views  5      *    $Test_Task_WPF.Views.ExchangeRateView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Test_Task_WPF.Views     5      .??5	      ? $??20 10q?6     ? ColumnDefinitions  5
   
   ?? 5      ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ?? 
???????$??0??61   $??2??6>   .+?5      ?? $??30??6D   $??30??6O      MenuButtonStyle#??[  6[   $??Right=?6?   $??0 0 0 0q?6?   ??6   ?? *NavigateToCoinListCommand+.??5      ?? $??/Resources/close.png??6   69   5      5      ?? 5   
   -   5        $??1??5   8   ??6E   ?? *Value1+6_   ?? 5   
   -   5        $??1??5   9   $??2??6F   ??6V   ?? *Value2+6p   ?? 5   
   $??1??6   $??2??6#   $??1??64   $??Center=?6D   .+?5      ?? $??/Resources/convert.png??6   $??22??65   5      ?? 5   
   $??0 20 0 0q?6   $??2??6e   ??6&   ?? *Items+ ?? SelectedValue 6E   ?? *Item1+??5       ?? 5!      .R?5"      ?? ??6    ?? *Name+68   5#      5%      ?? 5&   
   $??0 20 0 0q?6   $??2??6D   $??2??6Q   ??6&   ?? *Items+ 6a   ?? *Item2+??5'      ?? 5(      .R?5)      ?? ??6!   ?? *Name+69   5*      5,      5-      5.      