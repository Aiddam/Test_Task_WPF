   M S B A M L   `   `   `  ????H  DTest_Task_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Test_Task_WPF.ViewsTest_Task_WPF.Views  5      *    $Test_Task_WPF.Views.CoinsListingView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Test_Task_WPF.Views     5      .??5	      ?   ? RowDefinitions  5
   
   ?? 5      $
??auto ?6   6,   ?? 5      $
??auto ?6   6,    ? ColumnDefinitions 5   
   ?? 5      $
??auto ?6   6.   ?? 5      $??* ?6   6+   .+?5   
   ? $??0??6   $??2??6    5      ?? 5      $??* ?6#   6/   ?? 5      $
??auto ?6#   62   .+?5      ?? $??0??6   $??Center=?6(   $??Top 7 Coins??6E    
  Header#??[  6X   6z   5      ?? 5   
   $	??Top=?6   $??1??6,   $??2??69     List#??[ 6I   ??6g   ?? *Items+ ?? SelectedItem 5      ?? *Item+??5       ?? 5!       ?? 
TargetType" ??6   .?5"      ??  ?? Property ? ?? ?? Value$ Center=?6C   6T   5#       ?? View 5%      ?? 5&      .P?5'      ?? $??Image??6%    ?? CellTemplate 5(      ?? 5)      .R?5*   "   ?? $??37??6(   $??37??64   $??Center=?6?   ??6\   ?? *Small+5+      5-      ?? 5/      $
??Name??6%    50      ?? 51      .R?52   "   ??  ?? Padding$ 0 0 20 0q?6,   ??6?   ?? *Name+6W   53      55      ?? 58      $??Market Cap Rank??6%    59      ?? 5:      .R?5;   "   ?? $ 0 0 20 0q?6M   ??6,   ?? *Market_Cap_Rank+5=   #   5>      5@      ?? 5B      $??	Price BTC??6%    5C      ?? 5D      .R?5E   "   ?? $ 0 0 20 0q?6G   ??6,   ?? *	Price_Btc+5G   #   5H      5J      5K      5M      ?? 5N   
   $??1??6   	 ?? CornerRadius$	 40??6   $??95??60   $	??360??6;   $	??Top=?6H   
???   ????#1D212C$??	14,0,14,0q?6?   ._?5O      ?? 
 ?? Orientation$
 Vertical=?6   .+?5P      ?? $??/Resources/diamond.png??6   $??32??68   $
??0,22q?6C   ?? 5Q      $??0,10,0,0q?6     MenuButtonStyle#??[ 6+   ??6T   ?? *ExchangeRateCommand+.??5R      ?? $??/Resources/collage.png??6   $??22??6<   5S      ?? 5T      #??[ 6   ??6B   ?? *ExchangeRateCommand+.??5W      ?? $??/Resources/convert.png??6   $??22??6<   5Y      ?? 5Z      #??[ 6   ??6B   ?? *ProfileDetailedCommand+.??5[      ?? $??/Resources/profile.png??6   $??22??6<   5\      5^      5_      5`      5a      