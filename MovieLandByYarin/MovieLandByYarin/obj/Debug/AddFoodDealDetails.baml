   M S B A M L   `   `   `  ����K  GMovieLandByYarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MovieLandByYarinMovieLandByYarin  5   	   )    #MovieLandByYarin.AddFoodDealDetails   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MovieLandByYarin     5   	   -   5          � Title$  contactAdder��5      $	��400��6    $	��400��6-   
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��79* �6   �� 5      $	��57* �6   �� 5      $	��21* �6   �� 5      $	��79* �6   �� 5      $	��79* �6   �� 5      $	��79* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��	quantity:��6   $
��Left=�6&   $	��Top=�6A   $��15,10.333,0,0q�6Y   $��1��6p   $��2��6}   $	��116��6�   $��Century Schoolbook)�6�   �� 5   
   $��notes��6   $��2��6"   $	��116��66   $��Century Schoolbook)�6C   $��10,69,44.667,47.667q�6c   �� 5   
   $��product:��6   $	��Top=�6%   $��10,24,7.987,0q�6=   $��2��6T   $��18��6h   $��Century Schoolbook)�6t   �� 5   
   -   5         ��Name$ cmbType��5       �� DisplayMemberPath$ Product��6$    �� SelectedValuePath$ Id��6@   $��2��6|   $
��Left=�6�   $��22��6�   $	��Top=�6�   $	��120��6�   $��	11,42,0,0q�6�    �� SelectedValue 6X   �� *	ProductID+6�   �� 5!   
   -   5        $��2��5!   ,   $
��Left=�6@   $��23��6[    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��120��6�   $��15,42.333,0,0q�6�   $��1��6�    �� 	MaxLength$ 2��6�   ��6   �� *
Quantity+6�   �� 5"   
   -   5        $	��add��5"      $
��Left=�6   $	��Top=�6:   $��75��6R   $��2��6]   $��4��6q   $��	28,10,0,0q�6�   $��1��6�   $��41��6�   6�   5(      5)      