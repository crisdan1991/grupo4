package negocio;

import java.util.List;
import java.util.ArrayList;

/**
 *
 * @author crist
 */
public class Invoker {
   
    
    private List<Command> command = new ArrayList<>();

    public void recibirCommand(Command command){
        this.command.add(command);
    }

    public void realizarOperaciones() {
        this.command.forEach(x -> x.execute());
        this.command.clear();
    }

}
