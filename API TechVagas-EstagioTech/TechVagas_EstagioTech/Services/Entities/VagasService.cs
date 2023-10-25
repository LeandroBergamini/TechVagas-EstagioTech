﻿using AutoMapper;
using TechVagas_EstagioTech.Dtos.Entities;
using TechVagas_EstagioTech.Repositorios;
using TechVagas_EstagioTech.Repositorios.Interfaces;

namespace TechVagas_EstagioTech.Services.Entities
{
	public class VagasService
	{
		private readonly IVagasRepositorio _vagasRepositorio;
		private readonly IMapper _mapper;

		public VagasService(IVagasRepositorio vagasRepositorio, IMapper mapper)
		{
			_vagasRepositorio = vagasRepositorio;
			_mapper = mapper;
		}

		public async Task<VagasDto> BuscarPorId(int id)
		{
			var vagas = await _vagasRepositorio.BuscarPorId(id);
			return _mapper.Map<VagasDto>(vagas);
		}

		public async Task<IEnumerable<VagasDto>> BuscarTodasVagas()
		{
			var vagas = await _vagasRepositorio.BuscarTodasVagas();
			return _mapper.Map<IEnumerable<VagasDto>>(vagas);
		}
	}
}
