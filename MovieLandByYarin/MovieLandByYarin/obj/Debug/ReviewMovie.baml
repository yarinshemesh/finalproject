   M S B A M L   `   `   `  ����K  GMovieLandByYarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MovieLandByYarinMovieLandByYarin  5   	   "    MovieLandByYarin.ReviewMovie   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MovieLandByYarin     5   	   -   5          � Title$  review��5   
   $	��400��6   $	��400��6&   
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��number of stars:��6   $
��Left=�6-   $	��Top=�6H   $��	50,39,0,0q�6`   $��3��6s   $	��116��6�   $��Century Schoolbook)�6�   $��2��6�   �� 5   
   $�� MOVIE:��6   $
��Left=�6$   $	��Top=�6?   $��	10,39,0,0q�6W   $��2��6j   $	��116��6~   $��Century Schoolbook)�6�   �� 5   
   -   5        $	��ADD��5      $
��Left=�6!   $	��Top=�6<   $��75��6T   $��2��6_   $��3��6s   $��34,0,0,0q�6�   $��2��6�   $��41��6�   
�������$��Century Schoolbook)�6�   6�   �� 5   
   $��3��6.   $
��Left=�6B   $	��Top=�6]   $	��120��6u   $��45.667,67,0,0q�6�   $��2��6�   $��2��6�    �� Text 6   �� *
Star_num+.@�5      �� $��1��6   �� 5       $��2��6   �� 5!      $��3��6   5"      �� 5#   
   -   5         ��Name$ cmbType��5#       �� DisplayMemberPath$
 Name��6$    �� SelectedValuePath$ Id��6=   $��2��6v   $
��Left=�6�   $��24��6�   $	��Top=�6�   $	��120��6�   $��	10,65,0,0q�6�   $��2��6�    �� SelectedValue 6U   �� *Movies+6�   �� 5$   
   $��
Costumers:��6   $
��Left=�6'   $	��Top=�6B   $��	14,55,0,0q�6Z   $��2��6m   $	��116��6�   $��Century Schoolbook)�6�   $��1��6�   $��2��6�   $��20��6�   �� 5&   
   -   5        $ cos_list��5&      $
 Name��6%   $ Id��6>   $��2��6z   $
��Left=�6�   $��24��6�   $	��Top=�6�   $	��120��6�   $��14,17.333,0,0q�6�   $��2��6�    6V   �� *	Costumers+6�   5(      5)      