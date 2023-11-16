using OCP.v1;

SportCarEngine sportCarEngine = new SportCarEngine();
BusEngine busEngine = new BusEngine();
CarMechenic mechenic = new CarMechenic();

mechenic.Repair(sportCarEngine);
mechenic.Repair(busEngine);