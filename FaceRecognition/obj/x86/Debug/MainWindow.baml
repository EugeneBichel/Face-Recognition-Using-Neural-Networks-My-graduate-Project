   M S B A M L   `   `   `  ����J  FFaceRecognition, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:FaceRecognition.ControlsFaceRecognition.Controls  5   	   G(clr-namespace:FaceRecognition.PropertiesFaceRecognition.Properties  5   	        FaceRecognition.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ;Controls&clr-namespace:FaceRecognition.Controls     5   	   9Prop(clr-namespace:FaceRecognition.Properties     5   	   -   5        (   "FaceRecognition.Properties.Strings%    TrainAndTestImagesWindow_Title � Title# Z  5   	    � 
ResizeMode$ NoResize=�5   	    � Icon$$ \Resources\FaceRecognition.ico��5   	   .��5
      � -   5         �Name$ MainGrid��5
       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��35 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   9� -   5         9�Name$ ControlPanelExpander��5      $��1��5      $��0��5      $��3��5       9� ExpandDirection$ Right=�5      $��LeftToRight=�5      $y�Visible=�5      	 9� 
IsExpanded	 .  .��5      �� $
��Auto=�6   .��5      �  5      �� 5       $
��Auto �6(   �� 5!      $
��Auto �6(   .+�5#      �� $��0��6      BorderStyle#��[  6*   ._�5$      @   :FaceRecognition.Controls.SelectionRecognitionMethodControl  -   5        
  Name$
 selectionRecMethodControl��5$   E   5%      �� 5&      -   5         ��Name$  ResultsFaceRecMethodsPanel��5&      $y�Hidden=�6A   $��1��6U   #��[  6b   ._�5'      <   6FaceRecognition.Controls.ResultsFaceRecognitionControl  -   5          Name$ ResultsFaceRecControl��5'   A   5(      5)      5*      5+      9� 5,   
   -   5        $ ImageDataBasesExpander��5,      $��0��5-      $��2��5.      $ Up=�5/      $y�Visible=�50      	 . .��52      � -   5        $ ImageDataBasesGrid��52       53      �� 54      $��* �6$   �� 55      $��* �6$   �� 56      $
��Auto �6$    58      �� 59      $��* �6'   �� 5:      $
��Auto �6'   .+�5<      �� #��[  6   $��0��5=      $��0��5>      ._�5?      7   1FaceRecognition.Controls.SelectionDataBaseControl  -	   5          Name$ selectionDb��5?   8   5@      �� 5A      #��[  6   $��1��5B      $��0��5C      ._�5D      >   8FaceRecognition.Controls.SelectionTrainTestImagesControl  -
   5          Name$ selectionTrainTestImages��5D   ?   5E      �� 5F      #��[  6   $��2��5G      $��0��5H      ._�5I      �� -   5         ��Name$ GoPreprocBtn��5I      $��Preprocessing��5J      $��Right=�5K      $��Center=�5L        ButtonStyle#��[ 5M      5N      5O      5P      5Q      �� 5R   
   #��[  6   $��0��5S      $��0��6&   ._�5T      4   .FaceRecognition.Controls.RecognizePanelControl  -   5          Name$ recognizePanel��5T   -   $y�	Collapsed=�5U   -   5V      �� 5W   
   #��[  6   $��1��5X      $��0��6&   ._�5Y      8   2FaceRecognition.Controls.PreprocessingPanelControl  -   5          Name$ preprocessingPanel��5Y   1   $y�	Collapsed=�5Z   1   5[      �� 5\   
   #��[  6   $��3��5]      $��2��5^      ._�5_      �� .@�5`      �� -   5         ��Name$ statusBarItem��5`       $��Stretch=�5a   (   .��5b      �� $0��*Testing Face Recognition Algoritms Program��6      TextBlockStyle#��[ 5c   (   ��5d   (   ��  �� ElementName$ statusBarItem�� �� Path$ Width�5e      5f      5g      5h      5i      