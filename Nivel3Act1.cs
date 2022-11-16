using System;

public class CuentaJoven(){
	public String titular = "Pepe";
	public int edad = 26;
	public int cantidad = 2300;

public Constructor(String titular, int edad, int cantidad) {
	this.titular = titular;
	this.edad =  edad;
	this.cantidad = cantidad;
	
	private String titular {
		get { return titular; }
		set { titular = value; }
	}
	
	private int edad {
		get { return edad; }
		set { edad = value; }
	}
	
	private int cantidad {
		get { return cantidad; }
		set { cantidad = value }
	}
}
public elTitularEsValido() {
	if ((this.edad >= 18) && (this.edad <= 25){
		return true;
	} else {
		return false;
	}
}
public retirar() {
	Console.WriteLine("Tu saldo: "+ get.cantidad);
	Console.WriteLine("¿Cuanto dinero quieres retirar?: ");
	double cantidadRetirar = double.Parse(Console.ReadLine());
	
	if (cantidadRetirar > get.cantidad || cantidadRetirar < 0) {
		Console.WriteLine("El numero introducido es invalido ");
	} else {
		cantidadRetirar = cantidad - cantidadRetirar;
	} while (cantidad != 0);
	Console.WriteLine("Tu saldo: " + cantidad);
	Console.Read();
	}
	
public ingresar() {
	Console.WriteLine("Tu saldo: "+ get.cantidad);
	Console.WriteLine("¿Cuanto dinero quieres ingresar?: ");
	double cantidadIngresar = double.Parse(Console.ReadLine());
	
	if (cantidadIngresar = 0) {
		Console.WriteLine("El numero introducido es invalido ");
	} else {
		cantidadIngresar = cantidad + cantidadIngresar;
	} while (cantidad != 0);
	Console.WriteLine("Tu saldo: " + cantidad);
	Console.Read();
}
}
public mostrar() {
	Console.WriteLine("Nombre: " + get.titular);
	Console.WriteLine("Edad: " + get.edad);
	Console.WriteLine("Cantidad: " + get.cantidad);
	}
}