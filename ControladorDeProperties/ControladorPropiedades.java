package TestMTTR;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStream;
import java.util.Properties;

public class ControladorPropiedades {
    
    public static void main(String[] args) {
        Properties propiedades = new Properties();
        InputStream entrada = null;
        final String archivoConfiguracion = ".\\src\\test\\java\\TestMTTR\\Selectores.properties";
    
        try{
        	/* Este controlador es para agregar, editar o testear elementos al archivo .properties en caso de ser necesario*/    
        	
            entrada = new FileInputStream(archivoConfiguracion);
            propiedades.load(entrada);

            /* En la siguiente variable ingresar el elemento a agregar al archivo, hay que considerar en en caso de que sea un
             * xpath como por ejemplo [@id=\"content\"], hay que cambiar las \" por comillas simples ' quedando como [@id='content']
             */
            
            String elemento = "\"//*[@id='content']/div[2]/p-autocomplete/span/input\"";
            
            /* En la siguiente línea de código, se debe ingresar propiedades.setProperty("Nombre_Del_Elemento", iTram);*/
            propiedades.setProperty("ImputTramite", elemento);
                             
            /* La siguiente impresión es para verificar que el elemento sea ingresado correctamente, 
             * ingresarlo de la siguiente manera: System.out.println(propiedades.getProperty("Nombre_Del_Elemento"));
             */
            System.out.println(propiedades.getProperty("ImputTramite"));

            propiedades.store(new FileWriter(archivoConfiguracion), "Ultima actualizacion del fichero: ");

            System.out.println("Se han cargado datos en el archivo de configuraciÃ³n");
    
        }catch(FileNotFoundException e){
            e.printStackTrace();
        }catch(IOException e){
            e.printStackTrace();
    
        }

    }


}
    

