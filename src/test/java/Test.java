import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

public class Test {

    public static void main(String[] args) {
        System.setProperty("webdriver.chrome.driver", "C:\\zmienne\\chromedriver.exe"); //sciezka do chromedriver
        WebDriver driver = new ChromeDriver(); // obiekt inicjalizujacy przegladarke
        WebDriverWait wait=new WebDriverWait(driver, 20); //deklaracja oczekiwania
        driver.manage().window().maximize(); //maksymalizacja okna przegladarki
        driver.get("http://www.google.com"); //przejscie do urla
        driver.findElement(By.name("q")).sendKeys("test"); //znalezienie elementu po nazwie i wpisanie slowa
        WebElement click; //deklaracja elementu
        click = wait.until(ExpectedConditions.visibilityOfElementLocated(By.name("btnK"))); //czekanie na pojawienie sie elementu
        driver.findElement(By.name("btnK")).click();
    }
}