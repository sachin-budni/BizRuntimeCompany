package mavenproject.nammaproject;

public class HeamMemory 
{
	public static void main(String[] args) 
	{
		long heapSize = Runtime.getRuntime().totalMemory();

        System.out.println("Heap Size = " + heapSize/(1024*1024));
	}
}
