package factory

import (
	"design-pattern-examples/go/04-AbstractFactory/model"
	"fmt"
)

type IFactory interface {
	CreatePhone() model.IPhone
}

func GetFactory(phoneType string) (IFactory, error) {
	if phoneType == "motorola" {
		return &MotorolaFactory{}, nil
	} else if phoneType == "samsung" {
		return &SamsungFactory{}, nil
	}
	return nil, fmt.Errorf("An error occurred")
}

type MotorolaFactory struct {
}

func (f *MotorolaFactory) CreatePhone() model.IPhone {
	return &model.MotorolaPhone{
		Phone: model.Phone{
			Brand:   "Motorola",
			Name:    "1222",
			Color:   "Blue",
			Storage: "128GB",
		},
	}
}

type SamsungFactory struct {
}

func (f *SamsungFactory) CreatePhone() model.IPhone {
	return &model.SamsungPhone{
		Phone: model.Phone{
			Brand:   "Samsung",
			Name:    "A10",
			Color:   "White",
			Storage: "256GB",
		},
	}
}
