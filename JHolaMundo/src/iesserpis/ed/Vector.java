package iesserpis.ed;

import java.util.Arrays;

public class Vector {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
	}
	public static int max(int[] v) {
		//Vector vacío
		if(v.length == 0)
			throw new IllegalArgumentException();
		//Vector máximo
			int max = v[0];
			for(int index = 1; index<v.length; index++) {
				if(v[index]> max)
					max = v[index];
			}
			return max;
		}
	public static void selectionSort(int[] v1) {
		
		
		for( int i= 0; i< v1.length -1; i++) {
			for (int j= i+1; j< v1.length; j++) {
				
				if(v1.length == 0)
					throw new IllegalArgumentException();
				if(v1[i]> v1[j]) {
					//Intercambiamos valores 
					int variableauxiliar = v1[i];
					v1[i] = v1[j];
					v1[j]= variableauxiliar;
				}
				
			}
		}
		 

		
	}
		

	}


