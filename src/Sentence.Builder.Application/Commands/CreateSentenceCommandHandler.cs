﻿using AutoMapper;
using MediatR;
using Sentence.Builder.Application.DTOs;
using Sentence.Builder.Application.Interfaces;
using Sentence.Builder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence.Builder.Application.Commands
{
    public class CreateSentenceCommandHandler : IRequestHandler<CreateSentenceCommand, SentenceDTO>
    {
        private readonly ISentenceContext _context;
        private readonly IMapper _mapper;
        public CreateSentenceCommandHandler(ISentenceContext sentenceContext, IMapper mapper)
        {
            _context = sentenceContext;
            _mapper = mapper;
        }

        public async Task<SentenceDTO> Handle(CreateSentenceCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<SentenceEntity>(request.Sentence);
            _context.Sentences.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);
            return _mapper.Map<SentenceDTO>(entity);
        }
    }
}
