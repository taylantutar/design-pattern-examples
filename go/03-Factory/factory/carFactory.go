package factory

import (
	"design-pattern-examples/go/03-Factory/model"
	"fmt"
)

func GetCar(carType string) (model.ICar, error) {
	if carType == "1" {
		return model.NewBMW1(), nil
	} else if carType == "2" {
		return model.NewBMW2(), nil
	}

	return nil, fmt.Errorf("Car not found")
}
