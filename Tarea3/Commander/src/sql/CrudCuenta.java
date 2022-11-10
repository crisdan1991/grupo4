
package sql;

import getset.Cuenta;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import javax.swing.JOptionPane;


 
public class CrudCuenta extends ConexionSQl {

    java.sql.Statement st;
    ResultSet rs;
    Cuenta cuenta;
    public void insertar(String numerocuenta, Double saldo) {
        try {
            Connection conexion = conectar();
            st = conexion.createStatement();
            String sql = "insert into cuenta(numerocuenta,saldo) values('" + numerocuenta + "','" + saldo + "');";
            st.execute(sql);
            st.close();
            conexion.close();
            JOptionPane.showMessageDialog(null, "El registro se guardo correctamente", "Mensaje", JOptionPane.INFORMATION_MESSAGE);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "El registro no se guardo " + e, "Mensaje", JOptionPane.ERROR_MESSAGE);
        }
    }
    public void insertarC(String numerocuenta, Double saldo, String operacion) {
        try {
            Connection conexion = conectar();
            st = conexion.createStatement();
            String sql = "insert into cuenta(numerocuenta,saldo,operacion) values('" + numerocuenta + "','" + saldo + "','" + operacion + "');";
            st.execute(sql);
            st.close();
            conexion.close();
            JOptionPane.showMessageDialog(null, "El registro se guardo correctamente", "Mensaje", JOptionPane.INFORMATION_MESSAGE);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "El registro no se guardo " + e, "Mensaje", JOptionPane.ERROR_MESSAGE);
        }
    }

    public List<Cuenta> mostrar(String numerocuenta) {
        List<Cuenta> cuentas = new ArrayList<>();
        try {
            Connection conexion = conectar();
            st = conexion.createStatement();
            String sql = "select * from cuenta where numerocuenta='" + numerocuenta + "';";
            rs = st.executeQuery(sql);
            Double saldodis = 0.0;
            while(rs.next()){
                  cuenta = new Cuenta(rs.getString("numerocuenta"),rs.getDouble("saldo"));
                  System.out.println(rs.getString("numerocuenta"));
                  cuentas.add(cuenta);
                  saldodis=rs.getDouble("saldo");
              }
             
           
             if(cuentas.isEmpty()){
                JOptionPane.showMessageDialog(null, "no se encontro registro", "sin registro", JOptionPane.INFORMATION_MESSAGE);
             }else if( saldodis>0 && !cuentas.isEmpty()){
               JOptionPane.showMessageDialog(null, "Cuenta registrada tiene un saldo de: "+saldodis, "Cuenta Encontrada", JOptionPane.INFORMATION_MESSAGE);
             } else{
               cuentas.clear();
               JOptionPane.showMessageDialog(null, "Cuenta registrada tiene un saldo de: "+saldodis, "Cuenta Encontrada", JOptionPane.INFORMATION_MESSAGE);
             }
             
             

            /*if (rs.next()) {
               JOptionPane.showMessageDialog(null, "Cuenta registrada tiene un saldo de: "+saldodis, "Cuenta Encontrada", JOptionPane.INFORMATION_MESSAGE);
            } else {
                cuenta = new Cuenta("",0);

                JOptionPane.showMessageDialog(null, "no se encontro registro", "sin registro", JOptionPane.INFORMATION_MESSAGE);
            }*/
            st.close();
            conexion.close();

        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "error en programa " + e, "Erro de sistema", JOptionPane.ERROR_MESSAGE);
        }
        return cuentas;
    }

    public void actualizar(String nombre, String apellido, String puesto, String idempleado) {
        try {
            Connection conexion = conectar();
            st = conexion.createStatement();
            String sql = "update empleados set nombre='" + nombre + "',apellido='" + apellido + "',puesto='" + puesto + "' where idempleado='" + idempleado + "'; ";
            st.executeUpdate(sql);
            st.close();
            conexion.close();
            JOptionPane.showMessageDialog(null, "El registro se actualizo", "Exito", JOptionPane.INFORMATION_MESSAGE);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error al actualizar " + e, "Error", JOptionPane.ERROR_MESSAGE);
        }
    }
    
    public void eliminar(String idempleado){
        try {
            Connection conexion=conectar();
            st=conexion.createStatement();
            String sql="delete from empleados where idempleado='"+idempleado+"'; ";
            st.executeUpdate(sql);
            st.close();
            conexion.close();
            JOptionPane.showMessageDialog(null, "Registro eliminado correctamente","Eliminado",JOptionPane.INFORMATION_MESSAGE);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error al eliminar registro "+ e,"Error",JOptionPane.ERROR_MESSAGE);
        }
    }
    
}
