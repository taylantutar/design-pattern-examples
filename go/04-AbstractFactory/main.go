package main

import (
	"design-pattern-examples/go/04-AbstractFactory/factory"
	"fmt"
)

func main() {
	motorolaFactory,_ := factory.GetFactory("motorola")
	motorolaPhone := motorolaFactory.CreatePhone()
	fmt.Println(motorolaPhone.GetInformation())

	fmt.Println()

	samsungFactory,_ := factory.GetFactory("samsung")
	samsungPhone := samsungFactory.CreatePhone()
	fmt.Println(samsungPhone.GetInformation())
}