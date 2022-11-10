package getset;

import javax.swing.JOptionPane;
import sql.CrudCuenta;


    
//Receiver/Request 
public class Cuenta {

	private int id;
        private String numerocuenta;
	private double saldo;

	public Cuenta(String numerocuenta, double saldo) {	
		this.numerocuenta = numerocuenta;
		this.saldo = saldo;
	}

	public void retirar(double monto) {
		this.saldo = this.saldo - monto;
                CrudCuenta crud=new CrudCuenta();
                crud.insertarC(this.numerocuenta, this.saldo,"-"+monto);
                JOptionPane.showMessageDialog(null, "Su nuevo saldo disponible es: "+ this.saldo+" $", "Retiro con exito", JOptionPane.INFORMATION_MESSAGE);
		System.out.println("[COMANDO RETIRAR] Cuenta: " + numerocuenta + " Saldo: " + this.saldo);
	}

	public void depositar(double monto) {
		this.saldo = this.saldo + monto;
                CrudCuenta crud=new CrudCuenta();
                crud.insertarC(this.numerocuenta, this.saldo,"+"+monto);
                JOptionPane.showMessageDialog(null, "Su nuevo saldo disponible es: "+ this.saldo + " $", "Deposito con exito", JOptionPane.INFORMATION_MESSAGE);
		System.out.println("[COMANDO DEPOSITAR] Cuenta: " + numerocuenta + " Saldo: " + this.saldo);
	}


}
