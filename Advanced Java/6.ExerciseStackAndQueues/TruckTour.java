import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class TruckTour {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int n = Integer.parseInt(reader.readLine());
        ArrayDeque<Truck> queue = new ArrayDeque<>();
        Truck truck = null;

        while (n-- > 0) {
            String[] input = reader.readLine().split("\\s+");
            int amount = Integer.parseInt(input[0]);
            int distance = Integer.parseInt(input[1]);
            truck = new Truck(amount,distance);
            queue.offer(truck);
        }

        int index = 0;
        boolean isHighAmount = false;

        while (true) {

            Truck startStation = queue.removeFirst();
            queue.addLast(startStation);

            int currentAmount = startStation.getAmountPetrol();
            currentAmount -= startStation.getDistanceToNextPump();
            int currentStationCount = 1;

            while (currentAmount >= 0){
                Truck currentStation = queue.removeFirst();

                if(startStation == currentStation){
                    isHighAmount = true;
                    break;
                }

                queue.addLast(currentStation);
                currentAmount += currentStation.getAmountPetrol();
                currentAmount -= currentStation.getDistanceToNextPump();
                currentStationCount++;
            }

            if(isHighAmount){
                break;
            }

            index += currentStationCount;
        }

        System.out.println(index);
    }

    private static class Truck {

        private int amountPetrol;
        private int distanceToNextPump;

        private Truck(int amountPetrol, int distanceToNextPump) {
            this.setAmountPetrol(amountPetrol);
            this.setDistanceToNextPump(distanceToNextPump);
        }

        private int getAmountPetrol() {
            return this.amountPetrol;
        }

        private void setAmountPetrol(int amountPetrol) {
            this.amountPetrol = amountPetrol;
        }

        private int getDistanceToNextPump() {
            return this.distanceToNextPump;
        }

        private void setDistanceToNextPump(int distanceToNextPump) {
            this.distanceToNextPump = distanceToNextPump;
        }
    }
}

