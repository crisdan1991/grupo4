/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package sql;

import java.sql.Connection;
import java.sql.DriverManager;
import javax.swing.JOptionPane;

/**
 *
 * @author crist
 */
public class ConexionSQl {
    Connection conn=null;
    String url="jdbc:postgresql://127.0.0.1/javadb";
    String usuario="postgres";
    String clave="postgres";
    
    public Connection conectar(){
        try {
            Class.forName("org.postgresql.Driver");
            conn=DriverManager.getConnection(url,usuario,clave);
            
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null,"Error al conectar "+e,"Error",JOptionPane.ERROR_MESSAGE);
        }
    return conn;
    }
    
}
