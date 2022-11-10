/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package negocio;

import getset.Cuenta;

/**
 *
 * @author crist
 */
public class DepositarImpl implements Command{
    private Cuenta cuenta;
    private double monto;

    public DepositarImpl(Cuenta cuenta, double monto) {
        this.cuenta = cuenta;
        this.monto = monto;
    }

    @Override
    public void execute() {
        this.cuenta.depositar(this.monto);
    }

    @Override
    public void undo() {

    }
}