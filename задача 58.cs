Задача 58: Задайте две матрицы. Напишите программу, которая будет выполнять создание двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
 
 
int  rows  = ReadInt ( " Введите количество строк: " ) ;
int  columns  = ReadInt ( " Введите количество столбцов: " ) ;
int [ , ]  array  =  новый  int [ строки , столбцы ] ;
int [ , ]  SecondArray  =  новый  int [ строки , столбцы ] ;
int [ , ]  resultArray  =  новый  int [ строки , столбцы ] ;

FillArrayRandom ( массив ) ;
PrintArray2D ( массив ) ;

Консоль . ЗаписатьСтроку ( ) ;

FillArrayRandom ( второй массив ) ;
PrintArray2D ( второй массив ) ;

Консоль . ЗаписатьСтроку ( ) ;

если  ( массив . GetLength ( 0 )  ! = SecondArray . GetLength ( 1 ) )
{
    Консоль . WriteLine ( " Нельзя перемножить " ) ;
    вернуться ;
}
for  ( int  i  =  0 ;  я  < массив . GetLength ( 0 ) ;  я ++ )
{
    for  ( int  j  =  0 ;  j  < SecondArray . GetLength ( 1 ) ;  j ++ )
    {
        resultArray [ i , j ]  =  0 ;
        for  ( int  k  =  0 ;  k  < массив . GetLength ( 1 ) ;  k ++ )
        {
            resultArray [ i , j ]  += массив [ i , k ]  * SecondArray [ k , j ] ;
        }
    }
}

PrintArray2D ( результирующий массив ) ;



// функция ввода
int  ReadInt ( строковое  сообщение )
{
    Консоль . Написать ( сообщение ) ;
    вернуть Конвертировать . ToInt32 ( Console.ReadLine ( ) ) ; _ _
}

// функция увеличения массива случайными числами от 1 до 9
void  FillArrayRandom ( массив int [ , ]  )
{
    for  ( int  i  =  0 ;  я  < массив . GetLength ( 0 ) ;  я ++ )
    {
        for  ( int  j  =  0 ;  j  < массив . GetLength ( 1 ) ;  j ++ )
        {
            массив [ я , j ]  =  новый случайный ( ) . Следующий ( 1 ,  10 ) ;
        }
    }
}


 /*