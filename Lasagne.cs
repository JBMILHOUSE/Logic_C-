public class Lasagne {

   // retorna o tempo previsto da lasanha no forno
    public int ExpectedMinutesInOven() => 40;

    public int RemaningTimeInMinutes(int actualMinutesInOver) => ExpectedMinutesInOven() - actualMinutesInOver;

    public int PreparationTimeInMinutes(int numberOfLayers) => numberOfLayers * 2;

    public int ElapsedTimeInMinutes(int numberOfLayers, int actualMinutesInOver) => PreparationTimeInMinutes(numberOfLayers) + RemaningTimeInMinutes(actualMinutesInOver);

}