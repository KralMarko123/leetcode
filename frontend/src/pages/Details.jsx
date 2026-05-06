import React, { useEffect, useState } from 'react';
import { FiArrowLeft, FiBookOpen, FiCheck, FiCode, FiCopy, FiExternalLink, FiHash } from 'react-icons/fi';
import { useNavigate, useParams } from 'react-router-dom';
import { createHighlighterCore } from 'shiki/core';
import { createJavaScriptRegexEngine } from 'shiki/engine/javascript';
import csharp from 'shiki/langs/csharp';
import githubDark from 'shiki/themes/github-dark';
import Card from '../components/Card';
import { PROBLEMS } from '../constants/PROBLEMS';
import { ROUTES } from '../constants/ROUTES';
import PageContainer from '../layout/PageContainer';
import '../styles/page.css';
import './Details.css';

const shikiHighlighter = createHighlighterCore({
	engine: createJavaScriptRegexEngine(),
	langs: [csharp],
	themes: [githubDark]
});

const Details = () => {
	const navigate = useNavigate();
	const { number } = useParams();
	const [hasCopiedCode, setHasCopiedCode] = useState(false);
	const problem = PROBLEMS.find((currentProblem) => currentProblem.number === Number(number));
	const [highlightedCode, setHighlightedCode] = useState('');
	const codeSnippet = problem?.codeSnippet ?? '';
	const lineNumbers = codeSnippet.split('\n').map((_, index) => index + 1);

	useEffect(() => {
		let isActive = true;

		const highlightCode = async () => {
			if (!codeSnippet) {
				setHighlightedCode('');
				return;
			}

			const highlighter = await shikiHighlighter;
			const html = highlighter.codeToHtml(codeSnippet, {
				lang: 'csharp',
				theme: 'github-dark'
			});

			if (isActive) setHighlightedCode(html);
		};

		highlightCode();

		return () => {
			isActive = false;
		};
	}, [codeSnippet]);

	if (!problem) {
		return (
			<div className='page details-page'>
				<PageContainer>
					<Card extraClassNames={['fullwidth', 'empty-state']}>
						<h1 className='title'>Solution not found</h1>
						<p className='paragraph'>There is no solution for problem #{number} in this library.</p>
						<button type='button' className='action-button primary' onClick={() => navigate(ROUTES.HOME)}>
							<FiArrowLeft aria-hidden='true' />
							Back to solutions
						</button>
					</Card>
				</PageContainer>
			</div>
		);
	}

	const { title, description, approach, link, difficulty, number: problemNumber } = problem;

	const copyCode = async () => {
		await navigator.clipboard.writeText(codeSnippet);
		setHasCopiedCode(true);
		window.setTimeout(() => setHasCopiedCode(false), 1600);
	};

	return (
		<div className='page details-page'>
			<PageContainer>
				<div className='details-nav'>
					<button type='button' className='action-button' onClick={() => navigate(ROUTES.HOME)}>
						<FiArrowLeft aria-hidden='true' />
						Back
					</button>

					<a className='action-button primary' href={link} target='_blank' rel='noreferrer'>
						<FiExternalLink aria-hidden='true' />
						LeetCode
					</a>
				</div>

				<Card extraClassNames={['solution-heading', 'fullwidth']}>
					<div className='problem-meta-row'>
						<span className={`difficulty-badge ${difficulty}`}>{difficulty}</span>
						<span>
							<FiHash aria-hidden='true' />
							{problemNumber}
						</span>
						<span>
							<FiCode aria-hidden='true' />
							C#
						</span>
					</div>
					<h1 className='title'>{title}</h1>
				</Card>

				<div className='solution-content'>
					<section className='solution-section'>
						<div className='section-heading'>
							<FiBookOpen aria-hidden='true' />
							<h2 className='title dark secondary'>Problem</h2>
						</div>
						<Card extraClassNames={['fullwidth', 'danger']}>
							<p className='paragraph pre'>{description}</p>
						</Card>
					</section>

					<section className='solution-section'>
						<div className='section-heading'>
							<FiCode aria-hidden='true' />
							<h2 className='title dark secondary'>Approach</h2>
						</div>
						<Card extraClassNames={['fullwidth', 'success']}>
							<p className='paragraph pre'>{approach}</p>
						</Card>
					</section>

					<section className='solution-section solution-code'>
						<div className='section-heading'>
							<FiCode aria-hidden='true' />
							<h2 className='title dark secondary'>Code</h2>
						</div>
						<Card extraClassNames={['code', 'fullwidth']}>
							<div className='code-toolbar'>
								<span>C# solution</span>
								<button type='button' className='copy-code-button' onClick={copyCode}>
									{hasCopiedCode ? <FiCheck aria-hidden='true' /> : <FiCopy aria-hidden='true' />}
									{hasCopiedCode ? 'Copied' : 'Copy'}
								</button>
							</div>
							<div className='code-frame'>
								<ol className='code-line-numbers' aria-hidden='true'>
									{lineNumbers.map((lineNumber) => (
										<li key={lineNumber}>{lineNumber}</li>
									))}
								</ol>
								{highlightedCode ? (
									<div
										className='shiki-highlight'
										dangerouslySetInnerHTML={{ __html: highlightedCode }}
									/>
								) : (
									<pre className='shiki-loading'>Loading syntax highlighting...</pre>
								)}
							</div>
						</Card>
					</section>
				</div>
			</PageContainer>
		</div>
	);
};

export default Details;
