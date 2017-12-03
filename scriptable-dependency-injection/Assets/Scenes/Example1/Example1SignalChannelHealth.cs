using Gemserk.Signals;
using UnityEngine;

[CreateAssetMenu(menuName="Example1/Health Signal")]
public class Example1SignalChannelHealth : ScriptableObject, ISignalChannelGeneric<Health>
{
	readonly SignalChannelGeneric<Health> _delegate = new SignalChannelGeneric<Health>();

	#region ISignalChannelGeneric implementation
	public void Signal (Health signal)
	{
		_delegate.Signal (signal);
	}

	public void StartListening (ISignalListenerGeneric<Health> listener)
	{
		_delegate.StartListening (listener);
	}

	public void StopListening (ISignalListenerGeneric<Health> listener)
	{
		_delegate.StopListening (listener);
	}

	#endregion
	
}