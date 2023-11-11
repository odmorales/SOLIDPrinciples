// See https://aka.ms/new-console-template for more information

using SOLID.LiskovSubstitution;

IFlyable flyableBird = new Eagle();
flyableBird.Fly(); // Flying

IFlyable penguin = new Penguin();
penguin.Fly(); // Swimming, not flying

