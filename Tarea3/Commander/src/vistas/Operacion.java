package vistas;

import getset.Cuenta;
import java.util.ArrayList;
import java.util.List;
import negocio.DepositarImpl;
import negocio.Invoker;
import negocio.RetirarImpl;
import sql.CrudCuenta;



public class Operacion extends javax.swing.JFrame {

    Cuenta cnt ;
    Cuenta c ;
    public Operacion() {
        initComponents();
        txtmonto.setEditable(false);
        btnDepositar.setEnabled(false);
        btnRetirar.setEnabled(false);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        txtnumeroCuenta = new javax.swing.JTextField();
        btnbuscar = new javax.swing.JButton();
        txtmonto = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        btnregresar = new javax.swing.JButton();
        btnRetirar = new javax.swing.JButton();
        btnDepositar = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setText("Numero Cuenta");

        txtnumeroCuenta.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtnumeroCuentaActionPerformed(evt);
            }
        });

        btnbuscar.setText("buscar");
        btnbuscar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnbuscarActionPerformed(evt);
            }
        });

        txtmonto.setEditable(false);
        txtmonto.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtmontoActionPerformed(evt);
            }
        });

        jLabel2.setText("Monto");

        btnregresar.setText("Principal");
        btnregresar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnregresarActionPerformed(evt);
            }
        });

        btnRetirar.setText("Retirar");
        btnRetirar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnRetirarActionPerformed(evt);
            }
        });

        btnDepositar.setText("Depositar");
        btnDepositar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDepositarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(25, 25, 25)
                                .addComponent(jLabel2))
                            .addGroup(layout.createSequentialGroup()
                                .addContainerGap()
                                .addComponent(jLabel1)))
                        .addGap(32, 32, 32)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txtmonto, javax.swing.GroupLayout.PREFERRED_SIZE, 156, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(txtnumeroCuenta, javax.swing.GroupLayout.PREFERRED_SIZE, 175, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(btnbuscar))))
                    .addComponent(btnregresar)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(btnRetirar)
                        .addGap(18, 18, 18)
                        .addComponent(btnDepositar, javax.swing.GroupLayout.PREFERRED_SIZE, 84, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(103, 103, 103)))
                .addContainerGap(25, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(txtnumeroCuenta, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnbuscar))
                .addGap(47, 47, 47)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtmonto, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel2))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 90, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnRetirar)
                    .addComponent(btnDepositar))
                .addGap(66, 66, 66)
                .addComponent(btnregresar))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnregresarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnregresarActionPerformed
       Menu menu=new Menu();
       menu.setVisible(true);
       menu.setLocationRelativeTo(null);
       this.setVisible(false);
    }//GEN-LAST:event_btnregresarActionPerformed
    private void btnbuscarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnbuscarActionPerformed
        CrudCuenta crud=new CrudCuenta();
        List<Cuenta> cuentas = crud.mostrar(txtnumeroCuenta.getText());
        System.out.println(cuentas.size());
        if(!cuentas.isEmpty()){
            txtmonto.setEditable(true);
            c = cuentas.get(cuentas.size()-1);
            btnDepositar.setEnabled(true);
            btnRetirar.setEnabled(true);
        } else {
            txtmonto.setEditable(false);
            btnDepositar.setEnabled(false);
            btnRetirar.setEnabled(false);
        }       
    }//GEN-LAST:event_btnbuscarActionPerformed

    private void btnRetirarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRetirarActionPerformed
        RetirarImpl opRetirar = new RetirarImpl(c, Double.parseDouble(txtmonto.getText()));
        Invoker ivk = new Invoker();
        ivk.recibirCommand(opRetirar);
        ivk.realizarOperaciones();
        txtmonto.setEditable(false);
        txtmonto.setText("");
        txtnumeroCuenta.setText("");
        btnDepositar.setEnabled(false);
        btnRetirar.setEnabled(false);
    }//GEN-LAST:event_btnRetirarActionPerformed

    private void btnDepositarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnDepositarActionPerformed
        DepositarImpl opDepositar = new DepositarImpl(c, Double.parseDouble(txtmonto.getText()));
        Invoker ivk = new Invoker();
        ivk.recibirCommand(opDepositar);
        ivk.realizarOperaciones();
        txtmonto.setEditable(false);
        txtmonto.setText("");
        txtnumeroCuenta.setText("");
        btnDepositar.setEnabled(false);
        btnRetirar.setEnabled(false);
        
    }//GEN-LAST:event_btnDepositarActionPerformed

    private void txtmontoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtmontoActionPerformed
        
    }//GEN-LAST:event_txtmontoActionPerformed

    private void txtnumeroCuentaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtnumeroCuentaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtnumeroCuentaActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Operacion.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Operacion.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Operacion.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Operacion.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Operacion().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnDepositar;
    private javax.swing.JButton btnRetirar;
    private javax.swing.JButton btnbuscar;
    private javax.swing.JButton btnregresar;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JTextField txtmonto;
    private javax.swing.JTextField txtnumeroCuenta;
    // End of variables declaration//GEN-END:variables
}
