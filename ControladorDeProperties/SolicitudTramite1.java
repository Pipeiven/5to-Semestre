package TestMTTR;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStream;
import java.util.Properties;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.support.locators.RelativeLocator;

public class SolicitudTramite1 extends SelectoresComunes {
	
	
	

	public void Tr1_Cancela_Servicio_RNSTP(WebDriver driver) throws InterruptedException {
		
		Properties propiedades = new Properties();
        InputStream entrada = null;
        final String archivoConfiguracion = ".\\src\\test\\java\\TestMTTR\\Selectores.properties";
    
        try{
        	        	
            entrada = new FileInputStream(archivoConfiguracion);
            propiedades.load(entrada);
		
            By ImputTramite = By.xpath(propiedades.getProperty("ImputTramite"));
            By CheckAceptoTyCUreg = By.cssSelector(propiedades.getProperty("CheckAceptoTyCUreg"));
            By PagarUreg = By.cssSelector(propiedades.getProperty("PagarUreg"));
            By IrTGRUreg = By.cssSelector(propiedades.getProperty("IrTGRUreg"));
            By IconoBcoVirtualUreg = By.id(propiedades.getProperty("IconoBcoVirtualUreg"));
            By PagarLineaVirtualUreg = By.id(propiedades.getProperty("PagarLineaVirtualUreg"));
            By AutorzaPagoVirUreg = By.cssSelector(propiedades.getProperty("AutorzaPagoVirUreg"));
            By IngreseSuEmailUreg = By.name(propiedades.getProperty("IngreseSuEmailUreg"));
            By BotonIngreseSuEmailUreg = By.id(propiedades.getProperty("BotonIngreseSuEmailUreg"));
            By FinalizarTr = By.cssSelector(propiedades.getProperty("FinalizarTr"));
		
	
        	
		

            super.unidadDeRegistro1(driver);

            driver.findElement(ImputTramite).click();
            Thread.sleep(2000);
            driver.findElement(ImputTramite).sendKeys(
				"Cancelación de la Inscripción de un Servicio Inscrito en el Registro Nacional de Servicios de Transporte de Pasajeros");
            Thread.sleep(2000);

            By _IrTramiteUreg = RelativeLocator.with(By.tagName("li")).below(ImputTramite);
            driver.findElement(_IrTramiteUreg).click();
            Thread.sleep(2000);

            super.unidadDeRegistro2(driver);
            super.loginTramite(driver);
            super.identificacionDeServicio(driver);

            driver.findElement(CheckAceptoTyCUreg).click();
            Thread.sleep(2000);
            driver.findElement(PagarUreg).click();
            Thread.sleep(2000);

            driver.findElement(IrTGRUreg).click();
            Thread.sleep(4000);

            driver.findElement(IconoBcoVirtualUreg).click();
            Thread.sleep(2000);
            driver.findElement(PagarLineaVirtualUreg).click();
            Thread.sleep(2000);
            driver.findElement(AutorzaPagoVirUreg).click();
            Thread.sleep(2000);

            driver.findElement(IngreseSuEmailUreg).sendKeys("testing@mtt.gob.cl");
            Thread.sleep(2000);
            driver.findElement(BotonIngreseSuEmailUreg).click();
            Thread.sleep(5000);
			driver.findElement(FinalizarTr).click();
			Thread.sleep(15000);
		
        	}catch(FileNotFoundException e){
        		e.printStackTrace();
        	}catch(IOException e){
        		e.printStackTrace();
        	}

	}

}
