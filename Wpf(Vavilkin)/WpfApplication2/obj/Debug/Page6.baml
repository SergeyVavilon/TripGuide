   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5          WpfApplication2.Page6   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication2     5        N� Title$
  Root��5	      .��5      � ��5   
   �� 5       �� ImageSource$ Root.jpg��6    j� Stretch$
 Fill=�60   .+�5   
   �� -   5         ��Name$ label��5      $+��%Построение маршрута��6   $
��Left=�6=   $��	44,38,0,0q�6X   $	��Top=�6k   $��52��6�   $	��274��6�   $��24(�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ 	#FFFB0808��6#   $ 1Q�65   5      5      �� 5   
   -   5         ��Name$ 
CountryBox��5      $
��Left=�6'   $��
62,224,0,0q�6B   $	��Top=�6V   $	��192��6n   $��24��6z   	 J� Opacity$		 0.5Q�6�   ��5      �� 5      $	 0,1&�6&   $	 0,0&�65   .��5      � $ 	#FFF0F0F0��6#   $ 0Q�65   � 5      $ 	#FFE5E5E5��6#   $ 1Q�65   5      5      �� 5   
   -   5        $ CountryChoiceLable��5      $%��Выберите страну: ��6,   $
��Left=�6H   $��
62,188,0,0q�6c   $	��Top=�6w   
 J� RenderTransformOrigin$
 -0.316,0.692&�6�   $	��192��6�   $��36��6�   $��18(�6�   ��5       �� 5!      $ 0.5,1&�6&   $ 0.5,0&�67   .��5"      � $ Black��6#   $ 0Q�61   � 5#      $ 	#FFFB0B0B��6#   $ 1Q�65   5$      5&      �� 5'   
   -   5         ��Name$ button��5'      $1��+Редактировать Маршруты��66   $
��Left=�6W   $��1018,464,0,0q�6r   $	��Top=�6�   $	��319��6�   $��72��6�   $��24(�6�   ��6�   Z� ��6�   Z� ��5(      �� 5)      $ 0.5,1&�6&   $ 0.5,0&�67   .��5*      � $ Black��6#   $ 0Q�61   � 5+      $ 	#FFFF0A0A��6#   $ 1Q�65   5,      5.      �� 5/   
   -   5        $ PriceBox��5/      $
��Left=�6%   $��348,224,0,0q�6@   $	��Top=�6U   $	��226��6m   $��24��6y   $		 0.5Q�6�   $
 1.539,0.609&�6�   �� 50   
   -   5        $ AddRoot��50      $-��'Спланировать маршрут��69   $
��Left=�6X   $��176,468,0,0q�6s   $	��Top=�6�   $	��291��6�   $��68��6�   $��24(�6�   ��6�   Z� ��6�   Z� ��51      �� 52      $ 0.5,1&�6&   $ 0.5,0&�67   .��53      � $ Black��6#   $ 0Q�61   � 54      $ 	#FFFD0404��6#   $ 1Q�65   55      57      �� 58   
   -   5         ��Name$ TimeTextBox��58      $
��Left=�6'   $��24��6B   $��624,224,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��114��6�   $		 0.5Q�6�   �� 59   
   -   5        $ HotelChoiceLable��59      $��Цена отеля:��6*   $
��Left=�6@   $��348,188,0,0q�6[   $	��Top=�6p   $	��178��6�   $��36��6�   $��18(�6�   ��5:      �� 5;      $ 0.5,1&�6&   $ 0.5,0&�67   .��5<      � $ Black��6#   $ 0Q�61   � 5=      $ 	#FFFD0D0D��6#   $ 1Q�65   5>      5@      �� 5A   
   -	   5        $ 	TimeLable��5A      $3��-Введите количество дней:��6#   $
��Left=�6F   $��624,188,0,0q�6a   $	��Top=�6v   $��36��6�   $	��232��6�   $��18(�6�   ��5B      �� 5C      $ 0.5,1&�6&   $ 0.5,0&�67   .��5D      � $ Black��6#   $ 0Q�61   � 5E      $ 	#FFFB0909��6#   $ 1Q�65   5F      5H      �� 5I   
   -
   5         ��Name$ TotalCostList��5I      $
��Left=�6)   $��24��6D   $��998,224,0,0q�6P   $	��Top=�6e   $	��110��6}   
���   ����	#FFF9F9F9���	#FFFFFBFB$		 0.5Q�6�   �� 5J   
   -   5        $ RootList��5J      $
��Left=�6$   $��42��6?   $��
48,372,0,0q�6K   $	��Top=�6_   $	��926��6w   $ �� IsSynchronizedWithCurrentItem$ FalseY�6�   $��24(�6�   ��6�   Z� ��6�   Z� ��5K      �� 5L      $ 0.5,1&�6&   $ 0.5,0&�67   .��5M      � $ Black��6#   $ 0Q�61   � 5N      $ 	#FFFD0808��6#   $ 1Q�65   5O      5Q      �� 5R   
   -   5        $ label1��5R      $��Цена поездки:��6    $
��Left=�68   $��998,188,0,0q�6S   $	��Top=�6h   $	��158��6�   $��36��6�   $��18(�6�   ��6�   Z� ��5S      �� 5T      $ 0.5,1&�6&   $ 0.5,0&�67   .��5U      � $ Black��6#   $ 0Q�61   � 5V      $ 	#FFFD0D0D��6#   $ 1Q�65   5W      5Y      5\      5]      