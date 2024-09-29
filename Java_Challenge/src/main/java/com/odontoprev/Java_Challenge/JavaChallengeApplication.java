package com.odontoprev.Java_Challenge;

import com.odontoprev.Java_Challenge.domains.Cliente;
import com.odontoprev.Java_Challenge.domains.Consulta;
import com.odontoprev.Java_Challenge.domains.Dentista;
import com.odontoprev.Java_Challenge.domains.Usuario;
import com.odontoprev.Java_Challenge.gateways.ClienteRepository;
import com.odontoprev.Java_Challenge.gateways.ConsultaRepository;
import com.odontoprev.Java_Challenge.gateways.DentistaRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.boot.ApplicationArguments;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.context.event.ApplicationReadyEvent;
import org.springframework.context.event.EventListener;

import java.util.ArrayList;
import java.util.Date;


@SpringBootApplication
@RequiredArgsConstructor
public class JavaChallengeApplication {

	public static void main(String[] args) {
		SpringApplication.run(JavaChallengeApplication.class, args);
	}



}
