using System;

public class Libro(){
	public String titulo = "El señor de los anillos";
	public String autor = "Pepe";
	public int ejemplares = 10;
	public int ejemplaresPrestados = 4;
	
public class Constructor(String titulo, String autor, int ejemplares, int ejemplaresPrestados) {
	this.titulo = titulo;
	this.autor = autor;
	this.ejemplares = ejemplares;
	this.ejemplaresPrestados = ejemplaresPrestados;
	prestamo();
	devolucion();
	
	private String titulo {
		get { return titulo; }
		set { titulo = value; }
	}
	
	private String autor {
		get { return autor; }
		set { autor = value; }
	}
	
	private int ejemplares {
		get { return ejemplares; }
		set { ejemplares = value; }
	}
	
	private int ejemplaresPrestados {
		get { return ejemplaresPrestados; }
		set { ejemplaresPrestados = value }
	}
}
	
public prestamo() {
	ejemplaresPrestados++; //incrementa los ejemplares prestados
}
public devolucion() {
	ejemplaresPrestados--;
}
}
	