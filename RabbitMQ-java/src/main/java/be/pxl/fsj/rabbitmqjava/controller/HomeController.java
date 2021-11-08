package be.pxl.fsj.rabbitmqjava.controller;

import be.pxl.fsj.rabbitmqjava.domain.RabbitMQMessage;
import org.springframework.amqp.rabbit.core.RabbitTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HomeController {

    private final RabbitTemplate rabbitTemplate;

    @Autowired
    public HomeController(RabbitTemplate  amqpTemplate) {
        this.rabbitTemplate = amqpTemplate;
    }

    @GetMapping
    public ResponseEntity<String> GetMessage() {
        RabbitMQMessage message = new RabbitMQMessage("Hello from Java");
        rabbitTemplate.convertAndSend(message);

        return new ResponseEntity<>("Hello", HttpStatus.OK);
    }
}
