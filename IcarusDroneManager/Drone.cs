using System.Globalization;

namespace IcarusDroneManager;

public class Drone
{
	private string _clientName;
	private string _droneModel;
	private string _serviceProblem;
	private double _serviceCost;
	private int _serviceTag;

	public Drone(string clientName, string droneModel, string serviceProblem, double serviceCost, int serviceTag)
	{
		_clientName = clientName;
		_droneModel = droneModel;
		_serviceProblem = serviceProblem;
		_serviceCost = serviceCost;
		_serviceTag = serviceTag;
	}

	public string GetClientName()
	{
		return _clientName;
	}

	public void SetClientName(string clientName)
	{
		_clientName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(clientName.ToLower());
	}

	public string GetDroneModel()
	{
		return _droneModel;
	}
	
	public void SetDroneModel(string droneModel)
	{
		_droneModel = droneModel;
	}

	public string GetServiceProblem()
	{
		return _serviceProblem;
	}

	public void SetServiceProblem(string serviceProblem)
	{
		_serviceProblem = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(serviceProblem.ToLower());
	}

	public double GetServiceCost()
	{
		return _serviceCost;
	}
	public void SetServiceCost(double serviceCost)
	{
		_serviceCost = serviceCost;
	}

	public int GetServiceTag()
	{
		return _serviceTag;
	}

	public void SetServiceTag(int serviceTag)
	{
		_serviceTag = serviceTag;
	}

	public string GetDisplayName()
	{
		return $"Client Name: {_clientName}, Service Cost: {_serviceCost:C}";
	}
}