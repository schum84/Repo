import com.thoughtworks.selenium.webdriven.commands.WaitForCondition;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

public class test3 {
    public static void  main(String[] args){
        WebDriver driver = new ChromeDriver(); //inicjalizacja przegladarki
        WebDriverWait wait=new WebDriverWait(driver, 50); //funkcja oczekiwania
        driver.manage().window().maximize(); //maksymalizacja okna
        driver.get("http://demo.nopcommerce.com/"); //przejscie na urla
        driver.findElement(By.linkText("Apple MacBook Pro 13-inch")).click(); //znalezienie elementu i klikniecie
        driver.findElement(By.id("add-to-cart-button-4")).click(); //znalezienie elementu i klikniecie
        WebElement koszyk; //deklaracja elementu
        koszyk = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//*[@id='bar-notification']/div/p/a"))); // oczekiwanie az element bedzie klikalny
        koszyk.click(); //klikniecie elementu
        driver.findElement(By.xpath("//*[@id=\"shopping-cart-form\"]/div[1]/table/tbody/tr/td[4]/a[contains(text(),'" + "Apple MacBook Pro 13-inch" + "')]")); //sprawdzenie czy element zawiera napis
    }
}
