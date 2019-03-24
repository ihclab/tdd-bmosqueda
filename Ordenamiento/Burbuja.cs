using System;
using System.Collections.Generic;
using System.Text;

namespace Ordenamiento
{
    public class Burbuja
    {
    	public void Ordenar(int[] array) 
    	{
    		for(int i = 0; i < array.Length - 1; i++)
			{
				for(int j = 0; j < array.Length - 1 - i; j++)
				{
					if(array[j] > array[j + 1])
					{
						int aux = array[j];
						array[j] = array[j + 1];
						array[j + 1] = aux;
					}
				}
			}
    	}
    }
}
