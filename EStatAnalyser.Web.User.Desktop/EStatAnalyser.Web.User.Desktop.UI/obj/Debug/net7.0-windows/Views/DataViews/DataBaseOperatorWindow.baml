   M S B A M L   `   `   `  ����\  XEStatAnalyser.Web.User.Desktop.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullDclr-namespace:EStatAnalyser.Web.User.Desktop.UI.ViewModels.DataViews6EStatAnalyser.Web.User.Desktop.UI.ViewModels.DataViews  5   	   N    HEStatAnalyser.Web.User.Desktop.UI.Views.DataViews.DataBaseOperatorWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   VlocalDclr-namespace:EStatAnalyser.Web.User.Desktop.UI.ViewModels.DataViews     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	   $	��290��5
   	   $	��760��6    � 
ResizeMode$ NoResize=�6"   $��1q�68   
���   � � DataContext 5      V   PEStatAnalyser.Web.User.Desktop.UI.ViewModels.DataViews.DataBaseOperatorViewModel  5   
   .��5      � .+�5   
   �� $��
250,10,0,0q�6   $��30��6$   $	��100��60   $
��Left=�6<   $	��Top=�6W   $��Запрос:��6o   �� 5   
   $��
250,40,0,0q�6)   $��20��6=   $	��120��6I   $
��Left=�6U   $	��Top=�6p   ��6   �� *Query+6p   �� 5   
   $��380, 20, 0, 0q�6,   $
��Left=�6C   $	��Top=�6^   $��
Найти��6v   $��40��6�   $��90��6�   ��6   �� *Search+6�   �� 5   
   $��480, 20, 0, 0q�6+   $
��Left=�6B   $	��Top=�6]   $��40��6u   $��90��6�   ��6   �� *Reset+.��5      ��  �� TextAlignment$ Center=�6   Сбросить к�� 6<   изначальному6V   5      �� 5   
   $��	10,70,0,0q�67   $
��Left=�6J   $	��Top=�6e   $	��190��6}   $	��560��6�   ��6   �� *UploadDatas+ �� View 5      �� 5      .P�5      �� $��ID��6%    �� Width$ 50��61    �� DisplayMemberBinding 6<   �� *Id+�� 5      $��Имя оси X��6%   $ 65��68    6C   �� *
XFieldName+�� 5      $��Имя оси Y��6%   $ 65��68    6C   �� *
YFieldName+�� 5      $��Тип данных��6%   $ 90��69    6D   �� *
DataType+�� 5      $#��Описание данных��6%   $	 150��6>    6J   �� *Description+�� 5      $*��$Были анализированы:��6%   $	 130��6B    6N   �� *WasAnalysed+5      5       �� 5"   
   $��
600,10,0,0q�6   $��25��6$   $	��200��60   $
��Left=�6<   $	��Top=�6W   $��ID файла:��6o   �� 5#   
   $��
600,40,0,0q�6&   $��20��6:   $	��130��6F   $
��Left=�6R   $	��Top=�6m   ��6   �� *Id+6m   �� 5%   
   $��600, 70, 0, 0q�6.   $*��$Открыть для анализа��6E   $
��Left=�6c   $	��Top=�6~   $��25��6�   $	��130��6�   ��6   �� *
Analysis+6�   �� 5&   
   $��600, 105, 0, 0q�62   $+��%Удалить запись из БД��6J   $
��Left=�6i   $	��Top=�6�   $��25��6�   $	��130��6�   ��6   �� *DeleteFromDB+6�   �� 5'   
   $��600, 200, 0, 0q�6*   $��Справка��6B   $
��Left=�6T   $	��Top=�6o   $��25��6�   $	��130��6�   ��6   �� *Help+6�   �� 5(   
   $��600, 235, 0, 0q�6+   $��Закрыть��6C   $
��Left=�6U   $	��Top=�6p   $��25��6�   $	��130��6�   ��6   �� *Close+6�   5)      5*      