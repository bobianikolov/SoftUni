import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.math.BigDecimal;

public class EuroTrip {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        double quantityWurst = Double.parseDouble(reader.readLine());

        double priceWurstInBG = quantityWurst * 1.20;
        BigDecimal decimal = new BigDecimal(priceWurstInBG);
        BigDecimal marks = new BigDecimal("4210500000000");
        BigDecimal result = decimal.multiply(marks);
        System.out.printf("%.2f marks",result);
    }
}
