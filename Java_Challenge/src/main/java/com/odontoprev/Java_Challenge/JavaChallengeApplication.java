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

	private final ClienteRepository clienteRepository;
	private final DentistaRepository dentistaRepository;
	private final ConsultaRepository consultaRepository;

	@EventListener(value = ApplicationReadyEvent.class)
	public void setupCliente() {
		Date date = new Date();
		for (int i=0; i<=4; i++){
			Cliente clienteCadastrado = Cliente.builder()
					.usuario(Usuario.builder()
							.nome("Cliente "+ i)
							.dataNascimento(date)
							.Email("cliente"+i+"@gmail.com")
							.Celular("(11)99999-9999")
							.build())
					.cpf_cnpj("1234567891"+i)
					.cep("0000000"+i)
					.tipoPlano("Bem Estar White")
					.build();
			clienteRepository.save(clienteCadastrado);
		}
	}

	@EventListener(value = ApplicationReadyEvent.class)
	public void setupDentista() {
		Date date = new Date();
		for (int i=5; i<=9; i++){
			Dentista dentistaCadastrado = Dentista.builder()
					.usuario(Usuario.builder()
							.nome("Dentista "+ i)
							.dataNascimento(date)
							.Email("Dentista"+i+"@gmail.com")
							.Celular("(11)99999-9999")
							.build())
					.cpf_cnpj("1234567891"+i)
					.cepClinica("0000000"+i)
					.nomeClinica("Clinica "+i)
					.tipoClinica("Tipo 1")
					.alvaraFuncionamento(true)
					.siteRedesSocial("@Dentista_Odonto")
					.build();
			dentistaRepository.save(dentistaCadastrado);
		}
	}

	@EventListener(value = ApplicationReadyEvent.class)
	public void setupConsulta(){
		for (int i=1; i<=5; i++){
			Date date = new Date();
			Consulta consultaCadastrado = Consulta.builder()
					.dateConsulta(date)
					.tipoConsulta("Consulta periódica")
					.valorMedioConsulta(200.00)
					.build();
			consultaRepository.save(consultaCadastrado);
		}
	}

}
