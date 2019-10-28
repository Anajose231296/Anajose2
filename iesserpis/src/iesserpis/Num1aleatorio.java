package iesserpis;
import java.util.Random;
import java.util.Scanner;

public class Num1aleatorio {
	

	public static void main(String[] args) {
		Random random = new Random();
		int numeroAleatorio = random.nextInt(1000) + 1;
		System.out.println("Número aleatorio = " + numeroAleatorio);
		
		Scanner scanner = new Scanner (System.in);
		int numeroIntroducido;
		int contadorIntentos = 0;
		int extremoIzquierdo = 1;
		int extremoDerecho = 1000;
		
		do {
			contadorIntentos++;
			System.out.print("Adivina el número (de 1 a 1000):  ");
			numeroIntroducido = scanner.nextInt();
			
			if (numeroIntroducido < numeroAleatorio) 
				extremoIzquierdo = numeroIntroducido + 1;
				
			
			if (numeroIntroducido > numeroAleatorio)
				extremoDerecho = numeroIntroducido - 1;
				
		}
			while (numeroIntroducido != numeroAleatorio);
		System.out.println("Enhorabuena. Has acertado!!!" +contadorIntentos);
		}
      
		
	


	}


