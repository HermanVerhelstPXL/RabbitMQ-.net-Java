package be.pxl.fsj.rabbitmqjava.domain;

import java.io.Serializable;

public class RabbitMQMessage implements Serializable {
    private String message;

    public RabbitMQMessage(String message) {
        this.message = message;
    }

    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }
}
