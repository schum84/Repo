import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.support.ui.Select;

public class test2 {

    public static void main(String[] args) {
        WebDriver driver = new ChromeDriver(); //obiekt inicjalizujacy przegladarke
        driver.manage().window().maximize(); //maksymalizacja oknaa
        driver.get("http://demo.guru99.com/test/guru99home/"); //przejscei do urla
        driver.findElement(By.id("philadelphia-field-email")).sendKeys("peter@gmail.com"); //znalezienie pola i wpisanie tekstu
        Select sap = new Select(driver.findElement(By.id("awf_field-91977689"))); // deklaracja wyboru
        sap.selectByVisibleText("SAP ABAP"); //wybor z listy rozwijalnej
        driver.findElement(By.id("philadelphia-field-submit")).click(); // znalezienie elementu i klikniecie

    }
}
