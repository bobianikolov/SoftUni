import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class VehiclePark {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] inputVehicle = reader.readLine().split("\\s+");
        List<String> vehicles = new ArrayList<>();
        int counterForSoldVehicles = 0;

        for (String vehicle : inputVehicle) {
            vehicles.add(vehicle);
        }

        String input = "";
        while (!"End of customers!".equals(input = reader.readLine())) {
            String[] requests = input.toLowerCase().split("\\s+");
            String vehicle = requests[0];
            String seat = requests[2];
            char typeOfVehicle = vehicle.charAt(0);
            String totalVehicle = typeOfVehicle + seat;

            if (vehicles.contains(totalVehicle)) {
                System.out.println(String.format("Yes, sold for %d$",
                        typeOfVehicle * Integer.valueOf(seat)));
                counterForSoldVehicles++;
                vehicles.remove(totalVehicle);
            } else {
                System.out.println("No");
            }
        }

        System.out.println("Vehicles left: " + String.join(", ",vehicles));
        System.out.println(String.format("Vehicles sold: %d",counterForSoldVehicles));
    }
}
