package model

import "fmt"

type ICar interface {
	PrintCar()
}

type Car struct {
	Brand string
	Model string
	Color string
}

func (c * Car)PrintCar(){
	fmt.Printf("Brand: %s, Model:%s, Color:%s",c.Brand,c.Model,c.Color)
}