   M S B A M L   `   `   `  ����K  GMovieLandByYarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MovieLandByYarinMovieLandByYarin  5   	        MovieLandByYarin.Add_movie   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MovieLandByYarin     5   	   -   5          � Title$  contactAdder��5      $	��400��6   $	��400��6*   
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��
AGE LIMIT:��6   $
��Left=�6'   $	��Top=�6B   $��14,39.333,0,0q�6Z   $��2��6q   $��2��6~   $	��116��6�   $��Century Schoolbook)�6�   �� 5   
   $��TIME OF MOVIE:��6   $
��Left=�6+   $	��Top=�6F   $��	10,58,0,0q�6^   $��1��6q   $��2��6~   $	��116��6�   $��Century Schoolbook)�6�   �� 5   
   $��	DIRECTOR:��6   $��2��6&   $	��116��6:   $��Century Schoolbook)�6G   $��10,72,30,57q�6g   $��2��6|   �� 5   
   $��NAME:��6   $	��Top=�6"   $��
10,24,30,0q�6:   $��2��6N   $��18��6b   $��Century Schoolbook)�6n   �� 5   
   -   5        $��2��5   )   $
��Left=�6=   $��23��6X    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   $��	10,42,0,0q�6�   ��6   �� *Name+6�   �� 5    
   -   5        $	��ADD��5       $
��Left=�6!   $	��Top=�6<   $��75��6T   $��2��6_   $��3��6s   $��34,0,0,0q�6�   $��2��6�   $��41��6�   
�������$��Century Schoolbook)�6�   6�   �� 5"   
   $��2��6*   $
��Left=�6>   $	��Top=�6Y   $	��120��6q   $��10,3,0,0q�6}   $��2��6�    �� Text 6   �� *Time+.@�5#      �� $��morning��6   �� 5$      $��	afternoon��6   �� 5%      $��night��6   5&      �� 5'   
   $��2��6.   $
��Left=�6B   $	��Top=�6]   $	��120��6u   $��11,68.333,0,0q�6�   $��2��6�   $��2��6�    6   �� *	Age_Limit+.@�5(      �� $��8+��6   �� 5)      $	��14+��6   �� 5*      $	��18+��6   5+      �� 5/   
   -   5         ��Name$ cmbType��5/       �� DisplayMemberPath$ Director_Name��6$    �� SelectedValuePath$ Id��6F   $��2��6�   $
��Left=�6�   $��29��6�   $	��Top=�6�   $	��120��6�   $��	11,18,0,0q�6�   $��1��6�    �� SelectedValue 6^   �� *
Director+6�   52      53      