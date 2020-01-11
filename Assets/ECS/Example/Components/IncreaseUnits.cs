﻿using ME.ECS;

public class IncreaseUnits : IComponent<State, Point> {

    public Point AdvanceTick(State state, Point data, float deltaTime, int index) {

        data.unitsCount += data.increaseRate * deltaTime;
        return data;

    }

    void IComponent<State, Point>.CopyFrom(IComponent<State, Point> other) {}

}

public class IncreaseUnitsOnce : IComponent<State, Point> {

    public Point AdvanceTick(State state, Point data, float deltaTime, int index) {

        data.unitsCount += data.increaseRate * deltaTime;
        return data;

    }
    
    void IComponent<State, Point>.CopyFrom(IComponent<State, Point> other) {}
    
}
